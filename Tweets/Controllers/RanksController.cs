using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Tweets.Data;
using Tweets.Models;

namespace Tweets.Controllers
{
    public class RanksController : Controller
    {
        private readonly ApplicationDbContext _db;
        

        public RanksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public  IActionResult Index(int? page, int? _pageSize, string filterValue = null)
        {
            Expression<Func<Smartphone, bool>> filterExpressions = null;
            if (!string.IsNullOrEmpty(filterValue))
                filterExpressions = s => s.DeviceName.Contains(filterValue);
            
            var pageSize = _pageSize ?? 5;

            var smartphoneEntities = _db.Smartphones.AsQueryable();

            if (filterExpressions != null)
                smartphoneEntities = smartphoneEntities.Where(filterExpressions);

            IEnumerable<Smartphone> smartphonesList = smartphoneEntities;

            bool isAjaxRequest = HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest";
            if (isAjaxRequest)
                return PartialView("_SmartphoneTableDataPartial", smartphonesList);


            ViewBag.page = page > 0 ? page : page = 1;

            int start = (int)(page - 1) * pageSize;

            //Aktualny numer strony
            ViewBag.pageCurrent = page;
            
            //Rozmiar listy
            int totalPage = smartphonesList.Count();
            
            //Ilość wszystkich stron do wyświetlenia
            float totalNumsize = (totalPage / (float)pageSize);
            int numSize = (int)Math.Ceiling(totalNumsize);

            ViewBag.pageSize = pageSize;
            ViewBag.numSize = numSize;
           // ViewBag.smartphones = smartphonesList.OrderBy(x => x.Id).Skip(start).Take(pageSize);

            return View(smartphonesList.OrderBy(x => x.Id).Skip(start).Take(pageSize));
        }

    }
}
