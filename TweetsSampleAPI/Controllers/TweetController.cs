using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TweetsSampleAPI.Models;
using TweetsSampleAPI.Repository;

namespace TweetsSampleAPI.Controllers
{
    public class TweetController : ApiController
    {
       

        // GET api/values
        public IEnumerable<Tweet> Get(string startDate,string endDate)
        {
            TweetRepository repository = new TweetRepository();
            
            return repository.GetTweets(startDate, endDate);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
