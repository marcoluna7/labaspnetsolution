using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeEcommers.LogicLayer.Modelos;
using ShoeEcommers.LogicLayer.ServicesApp;

namespace ShoesEcommers.ShopWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServicesHome _service;

        public HomeController()
        {
            _service = new ServicesHome();
        }
        public ActionResult Index()
        {
            DataHomeSite data = _service.GetDataHome();
            return View(data);
        }

        protected override void Dispose(bool disposing)
        {
            _service.Dispose();
            base.Dispose(disposing);
        }
    }
}
