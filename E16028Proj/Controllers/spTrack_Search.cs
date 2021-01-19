using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using E16028Proj.Models;
using System;

namespace E16028Proj.Controllers
{
    public class spTrack_SearchController : Controller
    {
        private ChinookEntities db = new ChinookEntities();

        public ActionResult Index()
        {
            IEnumerable<spTrack_Search_Result> track = Enumerable.Empty<spTrack_Search_Result>();
            return View(track);
        }

        [HttpPost]
        public ActionResult Index(DateTime time1, DateTime time2)
        {

            try
            {
                IEnumerable<spTrack_Search_Result> sp2_results = db.spTrack_Search(time1, time2);
                return View(sp2_results);
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