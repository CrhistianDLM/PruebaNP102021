using System;
namespace NewsTime_APIRest.Models
{
    public class New
    {
        public int NewId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public string PublishedAt { get; set; }
        public string Content { get; set; }
        public int HistoryId { get; set; }
        public New()
        {
        }
    }
}
