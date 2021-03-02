using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Tweets.Models
{
    public class Tweet
    {
        public string TweetId { get; set; }
        public string Text { get; set; }
        public DateTime Created_at { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }
        public IList<string> HyperLink { get; set; }
    }
}
