using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using NewsTime_APIRest.Models;
namespace NewsTime_APIRest.Classes
{
    public class BasicUsageModel 
    {
        private readonly IHttpClientFactory _clientFactory;

        public IEnumerable<NewsModel> Branches { get; private set; }

        public bool GetBranchesError { get; private set; }

        public BasicUsageModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<NewsModel>> OnGet()
        {
            var keywork = "q=Apple";
            var sort = "&sortBy=popularity";
            var apiKey = "&apiKey=" + "e7a9dd937501437d981b7e743847d52a";
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://newsapi.org/v2/everything?"+keywork+sort+apiKey);
            //request.Headers.Add("Accept", "application/vnd.github.v3+json");
            //request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            var client = _clientFactory.CreateClient();
            //var client = _clientFactory.CreateClient("github");

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Branches = await JsonSerializer.DeserializeAsync
                    <IEnumerable<NewsModel>>(responseStream);
            }
            else
            {
                GetBranchesError = true;
                Branches = Array.Empty<NewsModel>();
            }
            return Branches;
        }
    }
}