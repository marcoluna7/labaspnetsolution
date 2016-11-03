using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeEcommers.LogicLayer.Entities;
using ShoeEcommers.LogicLayer.Modelos;

namespace ShoesEcommers.ShopWeb.Controllers
{
    public class ProductsController : Controller
    {
        public readonly ecommersEntities1 _dc;

        public ProductsController()
        {
            _dc = new ecommersEntities1();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Campaign(int id)
        {
            var query = from p in _dc.Products
                join s in _dc.Skus on p.Id equals s.IdProduct
                join a in _dc.AttributeSkus on s.Id equals a.IdSku
                        where p.Campaigns.Any(c => c.Id == id)
                        group s by new GroupsSkusFront { IdProduct = p.Id, ValueGroup= a.ValueLabel } into groupsData
                select groupsData;

            List<IGrouping<GroupsSkusFront, Skus>> result = query.ToList();
            return View(result);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            _dc.Dispose();
            base.Dispose(disposing);
        }
    }

    
}
