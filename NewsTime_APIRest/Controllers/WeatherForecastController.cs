using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NewsTime_APIRest.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Data.SqlClient;
using NewsTime_APIRest.Data.Services;

namespace NewsTime_APIRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HistoryService _historyService;
        private readonly IConfiguration _configuration;
        public WeatherForecastController(IHttpClientFactory httpClientFactory, ILogger<WeatherForecastController> logger, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _historyService = new HistoryService(configuration);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet ("/api/v1/search/{city}")]
        async public Task<IActionResult> SomeAction(string city)
        {            
            // Get an HttpClient configured to the specification you defined in StartUp.
            var client = _httpClientFactory.CreateClient("newsapi");
            
            var responseStream = await client.GetAsync("?q=" + city + "&apiKey=e7a9dd937501437d981b7e743847d52a");
            //var newsModel = await JsonSerializer.DeserializeAsync
            var newsModel = JsonConvert.DeserializeObject
                    <NewsModel>(value: await responseStream.Content.ReadAsStringAsync());            
            
            var client2 = _httpClientFactory.CreateClient("openweathermap");
            var responseStream2 = await client2.GetAsync("?q=" + city + "&appid=d5ca5c1602be24637de832af8d9fd632");

            var wheater = JsonConvert.DeserializeObject
                    <WheaterMap>(value: await responseStream2.Content.ReadAsStringAsync());
            //Mapeo de los datos de Current Weather
            NewsTime s = NewsTime.fromParameters(newsModel.articles, NewsTime.getFromWheaterMap(wheater));
            
            _historyService.AddHistory(s.mapHistory(city)); //Registra la busqueda en la tabla history
            //Aplicando formato al json para que las variables tengan estilo Snake Case
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };
            var json = JsonConvert.SerializeObject(s, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });
            return Ok(json);
        }
        [HttpGet("/api/v1/history")]
        public Histories[] IndexHistory()
        {
            return _historyService.GetHistories();
            //return "1";
        }
    }
}
