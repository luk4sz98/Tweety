using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Tweets.Models;

namespace Tweets.Controllers
{
    public class TweetsController : Controller
    {
        public static string searchValue;
        private static IEnumerable<Tweet> lista;
        private static readonly int pageSize = 2;
        public IActionResult Index(int? page)
        {
            if (lista != null)
            {
                ViewBag.page = page > 0 ? page : page = 1;


                int start = (int)(page - 1) * pageSize;

                //Aktualny numer strony
                ViewBag.pageCurrent = page;

                //Rozmiar listy
                int totalPage = lista.Count();

                //Ilość wszystkich stron do wyświetlenia
                float totalNumsize = (totalPage / (float)pageSize);
                int numSize = (int)Math.Ceiling(totalNumsize);

                ViewBag.numSize = numSize;
                ViewBag.tweets = lista.OrderBy(x => x.TweetId).Skip(start).Take(pageSize);

                return View();
            }
            else
                ViewBag.info = "Błąd";
                return View();
        }
           

        public IActionResult GetTweets()
        {
            var twitter = new TweeterAPI
            {
                ConsumerKey = "AtKwXQcRmuFgY9kgIdnkbQoOr",
                ConsumerSecretKey = "LRWPDwc2SMXrjGZOVhLecInlBf7xmUG6BjSw2xkm8rbOuJkIXu"
            };

            lista = twitter.GetTwittsWithKeywords($"{searchValue}").Result;
            return RedirectToAction("Index", lista);
        }
    }
}
