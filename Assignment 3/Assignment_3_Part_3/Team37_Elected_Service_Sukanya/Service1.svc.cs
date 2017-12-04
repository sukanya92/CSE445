using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Team37_Elected_Service_Sukanya
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /// <summary> 
        /// This function returns a list of top 10 URLs where the search keyword occurs
        /// </summary>
        /// <param name="Keywords"> The input keyword(s)</param>
        /// <return>array of URLs where above search term occurs</return>
        public string[] GetNewsFocus(string[] keywords)
        {
            string[] titles;
            String searchQuery = "";
            foreach (string s in keywords)
                searchQuery += s + " ";
            searchQuery = searchQuery.Trim();
            //const string accessKey = "f7e1c25de91f445cb865d1aaa5fd48a2";
            const string accessKey = "5f634cf7c65240dd8d3f0f98790dceb9";
            const string uriBase = "https://api.cognitive.microsoft.com/bing/v7.0/news/search";
            string searchTerm = searchQuery;
            var uriQuery = uriBase + "?q=" + Uri.EscapeDataString(searchTerm);
            WebRequest request = HttpWebRequest.Create(uriQuery);
            request.Headers["Ocp-Apim-Subscription-Key"] = accessKey;
            HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var searchResult = new SearchResult();
            searchResult.jsonResult = json;
            var errors = new List<string>();
            RootObjectFocus root = JsonConvert.DeserializeObject<RootObjectFocus>(json,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Include,
                    Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs earg)
                    {
                        errors.Add(earg.ErrorContext.Member.ToString());
                        earg.ErrorContext.Handled = true;
                    }
                });

            var ArticleList = root.value;
            int len = ArticleList.Count;
            titles = new string[len];
            int counter = 0;
            while (counter < len)
            {
                titles[counter] = ArticleList.ElementAt<Value>(counter).url;
                counter++;
            }

            return titles;

        }

        /// <summary> 
        /// This function returns a list of top 10 headlines in a news website
        /// </summary>
        /// <param name="URL"> The input URL</param>
        /// <return>array of news title coming as headlines in the respective news site</return>
        public string[] GetNewsHeadlines(string URL)
        {
            string[] titles = new string[10];
            var json = "";
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(URL);
            }

            var errors = new List<string>();
            RootObjectHeadlines root = JsonConvert.DeserializeObject<RootObjectHeadlines>(json,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Include,
                    Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs earg)
                    {
                        errors.Add(earg.ErrorContext.Member.ToString());
                        earg.ErrorContext.Handled = true;
                    }
                });

            var ArticleList = root.articles;
            int counter = 0;
            while (counter < 10)
            {
                titles[counter] = ArticleList.ElementAt<Article>(counter).title;
                counter++;
            }
            return titles;
        }

        struct SearchResult
        {
            public String jsonResult;
            public Dictionary<String, String> relevantHeaders;
        }
    }

    public class Instrumentation
    {
        public string pingUrlBase { get; set; }
        public string pageLoadPingUrl { get; set; }
    }

    public class Sort
    {
        public string name { get; set; }
        public string id { get; set; }
        public bool isSelected { get; set; }
        public string url { get; set; }
    }

    public class Thumbnail
    {
        public string contentUrl { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Image
    {
        public Thumbnail thumbnail { get; set; }
    }

    public class About
    {
        public string readLink { get; set; }
        public string name { get; set; }
    }

    public class Thumbnail2
    {
        public string contentUrl { get; set; }
    }

    public class Image2
    {
        public Thumbnail2 thumbnail { get; set; }
    }

    public class Provider
    {
        public string _type { get; set; }
        public string name { get; set; }
        public Image2 image { get; set; }
    }

    public class Thumbnail3
    {
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Video
    {
        public string name { get; set; }
        public string thumbnailUrl { get; set; }
        public string embedHtml { get; set; }
        public bool allowHttpsEmbed { get; set; }
        public Thumbnail3 thumbnail { get; set; }
    }

    public class Value
    {
        public string name { get; set; }
        public string url { get; set; }
        public string urlPingSuffix { get; set; }
        public Image image { get; set; }
        public string description { get; set; }
        public List<About> about { get; set; }
        public List<Provider> provider { get; set; }
        public DateTime datePublished { get; set; }
        public string category { get; set; }
        public Video video { get; set; }
    }

    public class RootObjectFocus
    {
        public string _type { get; set; }
        public Instrumentation instrumentation { get; set; }
        public string readLink { get; set; }
        public int totalEstimatedMatches { get; set; }
        public List<Sort> sort { get; set; }
        public List<Value> value { get; set; }
    }

    public class Article
    {
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public DateTime publishedAt { get; set; }
    }

    public class RootObjectHeadlines
    {
        public string status { get; set; }
        public string source { get; set; }
        public string sortBy { get; set; }
        public List<Article> articles { get; set; }
    }
}
