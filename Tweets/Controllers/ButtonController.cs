using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweets.Controllers
{
    public class ButtonController : Controller
    {
        public IActionResult Index(string itemsPerSize)
        {
            RanksController.pageSize = Int32.Parse(itemsPerSize);
            return RedirectToAction("Index", "Ranks", RanksController.pageSize);
        }

        public IActionResult SearchTweets(string inputValue)
        {
            TweetsController.searchValue = inputValue;
            return RedirectToAction("GetTweets", "Tweets", TweetsController.searchValue);
        }

    }
}
