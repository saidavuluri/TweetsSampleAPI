using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TweetsSampleAPI.Models;

namespace TweetsSampleAPI
{
    public class TweetHttpClient
    {
        private const string TweetsUrl = "https://badapi.iqvia.io/";
        private const string TweetsGetMethod = "api/v1/Tweets?startDate={0}&endDate={1}";
        /// <summary>
        /// Returns the list of tweets between the given dates
        /// </summary>
        /// <param name="startDate"> date from which tweets should be fetched</param>
        /// <param name="endDate">date until when the tweets should be fetched</param>
        /// <returns>list of tweets between the dates</returns>
        public List<Tweet> GetTweets(string startDate, string endDate)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(TweetsUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(string.Format(TweetsGetMethod,startDate,endDate)).Result;
                return response.Content.ReadAsAsync<List<Tweet>>().Result;
            }
        }
    }
}