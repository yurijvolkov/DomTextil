using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomTextil.Domain.Abstract;
using DomTextil.Domain.Concrete;
using DomTextil.Domain.Entities;

namespace DomTextil.Controllers
{   
    public class AdminController : Controller
    {
        private static IProductRepository Repository { get; set; } = new EFProductRepository();


        // GET: Admin
        //public ViewResult CreateNews()
        //{
        //    News news = new Domain.Entities.News();
        //    return ViewResult()
        //}
        public ViewResult Index()
        {
            return View();
        }

        //Editing News
        public ViewResult EditNews(int id)
        {
            News news = Repository.News.First(n => n.ID == id);
            return View(news);
        }
        [HttpPost]
        public ActionResult EditNews(News news, HttpPostedFileBase photo)
        {
            string fullpath = "";
            string map = "";
            if (photo != null)
            {
                string filename = System.IO.Path.GetFileName(photo.FileName);
                fullpath = "/Images/" + filename;
                map = Server.MapPath(fullpath);
                photo.SaveAs(map);
                news.Photo = fullpath;
            }
            Repository.Save(news);
            return RedirectToAction("News");

        }
        public ActionResult News()
        {
            return View(Repository.News);
        }
        public ActionResult CreateNews()
        {
            News news = new Domain.Entities.News();
            news.PublisTime = DateTime.Now;
            return View("EditNews", news);
        }
        public ActionResult DeleteNews(int id)
        {
            Repository.DeleteNews(id);
            return RedirectToAction("News");
        }

        // Editing products
        public ActionResult Products()
        {
            return View(Repository.Products);
        }
        public ViewResult EditProducts(int id)
        {
            Product product = Repository.Products.First(p => p.ID == id);
            return View(product);
        }
        [HttpPost]
        public ActionResult EditProducts(Product product, HttpPostedFileBase photo)
        {
            string fullpath = "";
            string map = "";
            if (photo != null)
            {
                string filename = System.IO.Path.GetFileName(photo.FileName);
                fullpath = "/Images/" + filename;
                map = Server.MapPath(fullpath);
                photo.SaveAs(map);
                    
                product.MainPhoto = fullpath;
            }
            Repository.Save(product);
            return RedirectToAction("Products");
        }
        public ActionResult CreateProducts()
        {
            Product product = new Product();
            return View("EditProducts", product);
        }
        public ActionResult DeleteProducts(int id)
        {
            Repository.Delete(id);
            return RedirectToAction("Products");
        }

        public ActionResult Discounts()
        {
            return View( Repository.Discount);
        }
        public ViewResult EditDiscount(int id)
        {
            var news = Repository.Discount.First(n => n.ID == id);
            return View(news);
        }
        [HttpPost]
        public ActionResult EditDiscount(Discount disc, HttpPostedFileBase photo)
        {
            string fullpath = "";
            string map = "";
            if (photo != null)
            {
                string filename = System.IO.Path.GetFileName(photo.FileName);
                fullpath = "/Images/" + filename;
                map = Server.MapPath(fullpath);
                photo.SaveAs(map);
                disc.Photo = fullpath;
            }
            Repository.Save(disc);
            return RedirectToAction("Discounts");

        }
        public ActionResult CreateDiscount()
        {
            Discount disc = new Domain.Entities.Discount();
            disc.PublisTime = DateTime.Now;
            return View("EditDiscount", disc);
        }
        public ActionResult DeleteDiscount(int id)
        {
            Repository.DeleteDiscount(id);
            return RedirectToAction("Discounts");
        }

    }
}