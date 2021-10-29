using System;
namespace NewsTime_APIRest.Models
{
    public class History
    {
        
        public int Id { get; set; }
        public string UserID { get; set; }
        public string City { get; set; }
        public string ObservationTime { get; set; }
        public float Temperature { get; set; }
        public string WeatherDescriptions { get; set; }
        public float WindSpeed { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }
        public int Pressure { get; set; }
        public int Precip { get; set; }
        public int Humidity { get; set; }
        public int Cloudcover { get; set; }
        public int Feelslike { get; set; }
        public int UvIndex { get; set; }
        public int Visibility { get; set; }
        public History()
        {
            
        }
    }
}
