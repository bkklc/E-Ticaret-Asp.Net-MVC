using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Ticaret.Models;

namespace E_Ticaret.Controllers
{
    public class HomeController : Controller
    {
        dtb1Entities category = new dtb1Entities();
        dtb1Entities product = new dtb1Entities();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult About()
        {           

            return View();
        }

        [Authorize]
        public ActionResult categorylist()
        {

            return View(category.Category.ToList());
        }
        [Authorize]
        public ActionResult productlist()
        {

            return View(product.Product.ToList());
        }
        [Authorize]
        public ActionResult productdetails()
        {

            return View();
        }


    }
}