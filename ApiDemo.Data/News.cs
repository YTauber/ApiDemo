using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace ApiDemo.Data
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
    
    public class NewsManager
    {
        public IEnumerable<News> GetNews()
        {
            List<News> News = new List<News>();
            HttpClient client = new HttpClient();

            string Url = "https://hacker-news.firebaseio.com/v0/topstories.json?print=pretty";
            string Json = client.GetStringAsync(Url).Result;
            List<string> ids = JsonConvert.DeserializeObject<List<string>>(Json);

            foreach (string s in ids.Take(20))
            {
                News.Add(GetNewsForId(s));
            }

            return News;
        }

        private News GetNewsForId(string id)
        {
            HttpClient client = new HttpClient();

            string Url = $"https://hacker-news.firebaseio.com/v0/item/{id}.json?print=pretty";
            string Json = client.GetStringAsync(Url).Result;
            return JsonConvert.DeserializeObject<News>(Json);
        }
    }
}
