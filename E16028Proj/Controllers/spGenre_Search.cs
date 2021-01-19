using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using E16028Proj.Models;
using System;

namespace E16028Proj.Controllers
{
    public class spGenre_SearchController : Controller
    {
        private ChinookEntities db = new ChinookEntities();


        [HttpPost]
        public ActionResult Index()
        {

            try
            {
                IEnumerable<spGenre_Search_Result> sp3_results = db.spGenre_Search();
                return View(sp3_results);
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