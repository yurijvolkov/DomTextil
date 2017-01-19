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
        private static IProductRepository Repository
        {
            get { return new EFProductRepository(); }
        }
        

        // GET: Home
        public ActionResult Start()
        {
            ViewBag.Title = "Стартовая страница";
            //   Discount d = new Domain.Entities.Discount() { Description = "desx", PublisTime = DateTime.Now, Text = "text", Title = "title" };
            
            return View();
        }
        //public PartialViewResult NewsAtom()
        //{
        //    IEnumerable<News> news = Repository.News
        //                                       .Select(x => x)
        //                                       .Distinct();
        //    return PartialView(news);
        //}
        public ActionResult Catalog(string category = "")
        {
            IEnumerable<Product> mas;

            if (category != "")
            {
                mas = Repository.Products
                                .Select(x => x)
                                .Where(x => x.SecondaryCategory == category);
            }
            else
            {
                mas = null;
            }
            return View(mas);
        }
        public PartialViewResult Menu()
        {
            Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>();
            IEnumerable<Product> products = Repository.Products
                                                  .Select(x => x);
            foreach (Product product in products)
            {
                if (categories.ContainsKey(product.MainCategory))
                {
                    if (!categories[product.MainCategory].Contains(product.SecondaryCategory))
                        categories[product.MainCategory].Add(product.SecondaryCategory);
                }
                else
                {
                    categories.Add(product.MainCategory, new List<string>(new string[] { product.SecondaryCategory }));
                }
            }

            return PartialView(categories);
        }
        public PartialViewResult Gallery()
        {
            ViewBag.imagesCount = 3;

            return PartialView();
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult News()
        {
            IEnumerable<News> news = Repository.News
                                               .Select(x => x)
                                               .Distinct();
            return View(news);
        }
        public ViewResult ConcreteNews(int newsId)
        {
            News news = Repository.News
                                 .Select(x => x)
                                 .Where(x => x.ID == newsId).ToArray()[0];
            return View(news);
        }
        public ViewResult Discount()
        {
            IEnumerable<Discount> discount = Repository.Discount
                                                       .Select(x => x)
                                                       .Distinct();
            return View(discount);
        }
        public ViewResult NewStuff()
        {
            IEnumerable<NewThings> newStuff = Repository.NewThings
                                                      .Select(x => x)
                                                      .Distinct();
            return View(newStuff);
        }
        public ViewResult Contacts()
        {
            return View();
        }


    }
}