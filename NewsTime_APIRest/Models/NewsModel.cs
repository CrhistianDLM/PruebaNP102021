using System;
namespace NewsTime_APIRest.Models
{
    public class NewsModel
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public News[] articles { get; set; }
        public NewsModel()
        {
        
        }
    }
}
