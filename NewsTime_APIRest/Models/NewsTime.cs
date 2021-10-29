namespace NewsTime_APIRest.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NewsTime
    {
        [JsonProperty("news")]
        public News[] News { get; set; }

        [JsonProperty("current_weather")]
        public CurrentWeather CurrentWeather { get; set; }

        
        public static NewsTime fromParameters(News[] news, CurrentWeather currentWeather){
            NewsTime instance = new NewsTime();
            instance.News = news;
            instance.CurrentWeather = currentWeather;
            return instance;
        }
        public static CurrentWeather getFromWheaterMap(WheaterMap wheater){
            CurrentWeather currentWeather = new CurrentWeather();
            currentWeather.ObservationTime = wheater.UnixTimeStampToDateTime(wheater.Dt);
            currentWeather.Temperature = wheater.Main != null ? wheater.Main.Temp : 0;
            currentWeather.WeatherDescriptions = wheater.Weather.Select(x => x.Description).ToArray();
            currentWeather.WindSpeed = wheater.Wind.Speed;
            currentWeather.WindDegree = wheater.Wind.Deg;
            currentWeather.WindDir = "N";
            currentWeather.Pressure = wheater.Main != null ? wheater.Main.Pressure : 0;
            currentWeather.Precip = wheater.Rain != null ? wheater.Rain.OneHour : -1;
            currentWeather.Humidity = wheater.Main != null ? wheater.Main.Humidity : 0;
            currentWeather.Cloudcover = wheater.Clouds.All;
            currentWeather.Feelslike = wheater.Main != null ? wheater.Main.FeelsLike : 0;
            currentWeather.UvIndex = 4;
            currentWeather.Visibility = wheater.Visibility;
            return currentWeather;
        }
        public History mapHistory(string city)
        {
            History h = new History();
            h.City = city;
            h.ObservationTime = CurrentWeather.ObservationTime.ToShortDateString();
            h.Temperature = (float)(CurrentWeather.Temperature);
            h.WeatherDescriptions = CurrentWeather.WeatherDescriptions[0];
            h.WindSpeed = (float)CurrentWeather.WindSpeed;
            h.WindDegree = (int)CurrentWeather.WindDegree;
            h.WindDir = CurrentWeather.WindDir;
            h.Pressure = (int)CurrentWeather.Pressure;
            h.Precip = (int)CurrentWeather.Precip;
            h.Humidity = (int)CurrentWeather.Humidity;
            h.Cloudcover = (int)CurrentWeather.Cloudcover;
            h.Feelslike = (int)CurrentWeather.Feelslike;
            h.UvIndex = (int)CurrentWeather.UvIndex;
            h.Visibility = (int)CurrentWeather.Visibility;
            return h;
        }
    }

    public partial class CurrentWeather
    {
        [JsonProperty("observation_time")]
        public DateTime ObservationTime { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("weather_descriptions")]
        public string[] WeatherDescriptions { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_degree")]
        public long WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure")]
        public long Pressure { get; set; }

        [JsonProperty("precip")]
        public double Precip { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("cloudcover")]
        public long Cloudcover { get; set; }

        [JsonProperty("feelslike")]
        public double Feelslike { get; set; }

        [JsonProperty("uv_index")]
        public long UvIndex { get; set; }

        [JsonProperty("visibility")]
        public long Visibility { get; set; }


    }

    public partial class News
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("urlToImage")]
        public Uri UrlToImage { get; set; }

        [JsonProperty("publishedAt")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
