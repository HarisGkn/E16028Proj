using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using E16028Proj.Models;
using System;

namespace E16028Proj.Controllers
{
    public class spMonthTrack_SearchController : Controller
    {
        private ChinookEntities db = new ChinookEntities();

        public ActionResult Index()
        {
            IEnumerable<spMonthTrack_Search_Result> mon = Enumerable.Empty<spMonthTrack_Search_Result>();
            return View(mon);
        }

        [HttpPost]
        public ActionResult Index(int year)
        {

            try
            {
                IEnumerable<spMonthTrack_Search_Result> sp6_results = db.spMonthTrack_Search(year);
                return View(sp6_results);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}