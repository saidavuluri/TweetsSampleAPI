using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetsSampleAPI.Models;

namespace TweetsSampleAPI.Repository
{
    public interface ITweetRepository
    {
        /// <summary>
        /// Returns the list of tweets between the given dates
        /// </summary>
        /// <param name="startDate"> date from which tweets should be fetched</param>
        /// <param name="endDate">date until when the tweets should be fetched</param>
        /// <returns>list of tweets between the dates</returns>
        List<Tweet> GetTweets(string startDate,string endDate);
    }
}
