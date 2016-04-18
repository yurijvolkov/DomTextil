using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomTextil.Domain.Concrete;
using DomTextil.Domain.Abstract;
using DomTextil.Domain.Entities;
namespace DomTextil.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository Repository { get; set; } = new EFProductRepository();

        // GET: Home
        public ActionResult Start()
        {
            ViewBag.Title = "Стартовая страница";
            return View();
        }
    }
}