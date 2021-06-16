using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweets.Interfaces;
using Tweets.Models;

namespace Tweets.Services
{
    public class TweetService : ITweetService
    {

        public IEnumerable<Tweet> GetTweets(string searchValue)
        {
            var twitter = new TweeterAPI
            {
                ConsumerKey = "AtKwXQcRmuFgY9kgIdnkbQoOr",
                ConsumerSecretKey = "LRWPDwc2SMXrjGZOVhLecInlBf7xmUG6BjSw2xkm8rbOuJkIXu"

            };

            return twitter.GetTwittsWithKeywords($"{searchValue}").Result;
        }
    }
}
