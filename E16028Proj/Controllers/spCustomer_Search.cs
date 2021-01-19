using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using E16028Proj.Models;
using System;

namespace E16028Proj.Controllers
{
    public class spCustomer_SearchController : Controller
    {
        private ChinookEntities db = new ChinookEntities();

        public ActionResult Index()
        {
            IEnumerable<spCustomer_Search_Result> cust = Enumerable.Empty<spCustomer_Search_Result>();
            return View(cust);
        }

        [HttpPost]
        public ActionResult Index(DateTime time1, DateTime time2)
        {

            try
            {
                IEnumerable<spCustomer_Search_Result> sp4_results = db.spCustomer_Search(time1, time2);
                return View(sp4_results);
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