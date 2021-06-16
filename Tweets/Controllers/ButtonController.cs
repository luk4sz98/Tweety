using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweets.Interfaces;

namespace Tweets.Controllers
{
    public class ButtonController : Controller
    {
        readonly ITweetService _tweetService;

        public ButtonController(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }
        public IActionResult Index(string itemsPerSize)
        {
           // RanksController.pageSize = Int32.Parse(itemsPerSize);
            return RedirectToAction("Index", "Ranks");
        }

        public IActionResult SearchTweets(string inputValue)
        {
            var listaParametru = _tweetService.GetTweets(inputValue);
            return RedirectToAction("Index", "Tweets", listaParametru);
           
        }

    }
}
