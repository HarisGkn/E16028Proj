using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using E16028Proj.Models;
using System;

namespace E16028Proj.Controllers
{
    public class spInvStat_SearchController : Controller
    {
        private ChinookEntities db = new ChinookEntities();


        [HttpPost]
        public ActionResult Index()
        {

            try
            {
                IEnumerable<spInvStat_Search_Result> sp7_results = db.spInvStat_Search();
                return View(sp7_results);
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