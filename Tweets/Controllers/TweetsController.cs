using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Tweets.Interfaces;
using Tweets.Models;

namespace Tweets.Controllers
{
    public class TweetsController : Controller
    {

        public static string searchValue;
        private static IEnumerable<Tweet> lista;
        private static readonly int pageSize = 3;

        readonly ITweetService _tweetService;

        public TweetsController(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }
        
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

        public IActionResult GetTweets(string inputValue)
        {
            lista = _tweetService.GetTweets(inputValue);
            return RedirectToAction("Index");
        }
           
    }
}
