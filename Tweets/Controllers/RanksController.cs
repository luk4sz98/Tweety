using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tweets.Data;
using Tweets.Models;

namespace Tweets.Controllers
{
    public class RanksController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        //liczba elementów listy wyświetlanych na raz
        public static int pageSize = 5;

        public RanksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? page)
        {

            IEnumerable<Smartphone> smartphonesList = _db.Smartphones;

            ViewBag.page = page > 0 ? page : page = 1;

            int start = (int)(page - 1) * pageSize;

            //Aktualny numer strony
            ViewBag.pageCurrent = page;
            
            //Rozmiar listy
            int totalPage = smartphonesList.Count();
            
            //Ilość wszystkich stron do wyświetlenia
            float totalNumsize = (totalPage / (float)pageSize);
            int numSize = (int)Math.Ceiling(totalNumsize);
            
            ViewBag.numSize = numSize;
            ViewBag.smartphones = smartphonesList.OrderBy(x => x.Id).Skip(start).Take(pageSize);

            return View();
        }

    }
}
