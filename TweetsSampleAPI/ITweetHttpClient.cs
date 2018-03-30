using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TweetsSampleAPI.Models;

namespace TweetsSampleAPI
{
    public interface ITweetHttpClient
    {
        /// <summary>
        /// Returns the list of tweets between the given dates
        /// </summary>
        /// <param name="startDate"> date from which tweets should be fetched</param>
        /// <param name="endDate">date until when the tweets should be fetched</param>
        /// <returns>list of tweets between the dates</returns>
        List<Tweet> GetTweets(string startDate, string endDate);
    }
}