using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DapperDemo.Entities;
using DapperDemo.Services;


namespace DapperDemo.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomerEntities xct)
        {
            CustomerServices cs = new CustomerServices();
            cs.Create(xct);

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}