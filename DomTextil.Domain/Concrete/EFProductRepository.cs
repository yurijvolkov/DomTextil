using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomTextil.Domain.Entities;

namespace DomTextil.Domain.Concrete
{
    public class EFProductRepository : Abstract.IProductRepository
    {

        private EFDbContext context = new EFDbContext();

        public IEnumerable<Discount> Discount
        {
            get
            {
                return context.Discount;
            }
        }
        public IEnumerable<News> News
        {
            get
            {
                return context.News;
            }
        }
        public IEnumerable<NewThings> NewThings
        {
            get
            {
                return context.NewThings;
            }
        }
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
        public void Delete(int id)
        {
            Product old = context.Products.First(x => x.ID == id);
            context.Entry(old).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public void DeleteNews(int id)
        {
            News old = context.News.First(x => x.ID == id);
            context.Entry(old).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public void DeleteDiscount(int id)
        {
            Discount old = context.Discount.First(x => x.ID == id);
            context.Entry(old).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public void Save(Product product)
        {
            if(context.Products.Select(x=>x)
                               .Where(x=>x.ID==product.ID)
                               .Count() == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product old = context.Products.First(x => x.ID == product.ID);
                old.Name = product.Name;
                old.Price = product.Price;
                old.Description = product.Description;
                old.MainCategory = product.MainCategory;
                old.SecondaryCategory = product.SecondaryCategory;
                if (product.MainPhoto != null)
                    old.MainPhoto = product.MainPhoto;
              
                context.Entry(old).State = System.Data.Entity.EntityState.Modified;

            }
            context.SaveChanges();
        }
        public void Save(News news)
        {
            if(context.News.Select(x=>x)
                           .Where(x=>x.ID==news.ID)
                           .Count()==0)
            {
                context.News.Add(news);
            }
            else
            {
                News old = context.News.First(x => x.ID == news.ID);
                old.Description = news.Description;
                if(news.Photo!=null)
                    old.Photo = news.Photo;
                old.PublisTime = news.PublisTime;
                old.Text = news.Text;
                old.Title = news.Title;
                context.Entry(old).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }
        public void Save(Discount discount)
        {
            context.Discount.Add(discount);
            context.SaveChanges();
        }
        public void Save(NewThings newThing)
        {
            context.NewThings.Add(newThing);
            context.SaveChanges();
        }
    }
}
