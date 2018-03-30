using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TweetsSampleAPI.Models;

namespace TweetsSampleAPI.Repository
{
    public class TweetRepository : ITweetRepository
    {
        /// <summary>
        /// Returns the list of tweets between the given dates
        /// </summary>
        /// <param name="startDate"> date from which tweets should be fetched</param>
        /// <param name="endDate">date until when the tweets should be fetched</param>
        /// <returns>list of tweets between the dates</returns>
        public List<Tweet> GetTweets(string startDate, string endDate)
        {
            TweetHttpClient httpClient = new TweetHttpClient();
            return httpClient.GetTweets(startDate, endDate);
        }
    }
}