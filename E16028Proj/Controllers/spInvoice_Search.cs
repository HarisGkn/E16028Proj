using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using E16028Proj.Models;
using System;

namespace E16028Proj.Controllers
{
    public class spInvoice_SearchController : Controller
    {
        private ChinookEntities db = new ChinookEntities();

        public ActionResult Index()
        {
            IEnumerable<spInvoice_Search_Result> inv = Enumerable.Empty<spInvoice_Search_Result>();
            return View(inv);
        }

        [HttpPost]
        public ActionResult Index(string cusName, string empName, DateTime time1, DateTime time2)
        {

            try
            {
                IEnumerable<spInvoice_Search_Result> sp5_results = db.spInvoice_Search(cusName, empName, time1, time2);
                return View(sp5_results);
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