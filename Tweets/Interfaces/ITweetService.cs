using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweets.Models;

namespace Tweets.Interfaces
{
    public interface ITweetService
    {
        IEnumerable<Tweet> GetTweets(string searchValue);

    }
}
