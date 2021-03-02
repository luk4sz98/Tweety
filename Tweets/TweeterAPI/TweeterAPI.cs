using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tweets.Models;

namespace Tweets
{
    public class TweeterAPI
    {
        public string ConsumerSecretKey { get; set; }
        public string ConsumerKey { get; set; }

        public async Task<IEnumerable<Tweet>> GetTwittsWithKeywords(string keyWord, string accessToken = null)
        {
            if (keyWord != "")
            {
                if (accessToken == null)
                    accessToken = await GetAccessToken();

                var requestKeywordsTweets = new HttpRequestMessage(HttpMethod.Get, string.Format($"https://api.twitter.com/2/tweets/search/recent?expansions=author_id&tweet.fields=created_at&query={keyWord}"));
                requestKeywordsTweets.Headers.Add("Authorization", "Bearer " + accessToken);

                var httpClient = new HttpClient();
                HttpResponseMessage responseKeywordsTweets = await httpClient.SendAsync(requestKeywordsTweets);

                var result = await responseKeywordsTweets.Content.ReadAsStringAsync();

                var jsonTweets = JObject.Parse(result);

                IList<Tweet> tweets = MakeTweetsList(jsonTweets);
                return tweets;
            }
            else
                return null;

        }

        private IList<Tweet> MakeTweetsList(JObject jObject)
        {
            var enumerator = 0;
            IList<Tweet> tweets = new List<Tweet>();
            foreach (var item in jObject["data"])
            {

                var tweetText = item.Value<string>("text").Substring(0, (item.Value<string>("text").IndexOf("https") != -1 ? item.Value<string>("text").IndexOf("https") : item.Value<string>("text").Length)).Trim();
                var tweetHyperlink = item.Value<string>("text").IndexOf("https") != -1 ? item.Value<string>("text")[item.Value<string>("text").IndexOf("https")..].Trim().Split(" ").ToList() : null;
                var tweetPostedAt = DateTime.ParseExact(item.Value<string>("created_at"), "MM/dd/yyyy HH:mm:ss", null);
                var tweetId = item.Value<string>("id");

                tweets.Add(new Tweet
                {
                    Text = tweetText,
                    Created_at = tweetPostedAt,
                    TweetId = tweetId,
                    HyperLink = new List<string>()
                });

                if (tweetHyperlink != null)
                    tweetHyperlink.ForEach(hyperlink => tweets[enumerator].HyperLink.Add(hyperlink));
                enumerator++;
            }

            for (int i = 0; i < jObject["includes"]["users"].Count(); i++)
            {
                tweets.ElementAt(i).UserId = jObject["includes"]["users"][i].Value<string>("id");
                tweets.ElementAt(i).UserName = jObject["includes"]["users"][i].Value<string>("username");
            }


            return tweets;
        }
        private async Task<string> GetAccessToken()
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.twitter.com/oauth2/token ");
            var customerInfo = Convert.ToBase64String(new UTF8Encoding().GetBytes(ConsumerKey + ":" + ConsumerSecretKey));
            request.Headers.Add("Authorization", "Basic " + customerInfo);
            request.Content = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");

            HttpResponseMessage response = await httpClient.SendAsync(request);

            string json = await response.Content.ReadAsStringAsync();
            dynamic item = JsonConvert.DeserializeObject(json);
            return item["access_token"];
        }
    }
}
