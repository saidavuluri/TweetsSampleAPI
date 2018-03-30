﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TweetsSampleAPI.Models
{
    public class Tweet
    {
        public string id
        {
            get;
            set;
        }

        public string text
        {
            get;
            set;
        }

        public DateTime stamp
        {
            get;
            set;
        }
    }
}