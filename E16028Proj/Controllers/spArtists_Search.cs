using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using E16028Proj.Models;
using System;

namespace E16028Proj.Controllers
{
    public class spArtists_SearchController : Controller
    {
        private ChinookEntities db = new ChinookEntities();

        public ActionResult Index()
        {
            IEnumerable<spArtists_Search_Result> art = Enumerable.Empty<spArtists_Search_Result>();
            return View(art);
        }

        [HttpPost]
        public ActionResult Index(int Quant, DateTime time1, DateTime time2)
        {

            try
            {
                IEnumerable<spArtists_Search_Result> sp1_results = db.spArtists_Search(Quant, time1, time2);
                return View(sp1_results);
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