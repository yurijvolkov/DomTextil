using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomTextil.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Entities.Product> Products { get; }
        IEnumerable<Entities.Discount> Discount { get; }
        IEnumerable<Entities.NewThings> NewThings { get; }
        IEnumerable<Entities.News> News { get; }
        void Delete(int id);
        void DeleteNews(int id);
        void DeleteDiscount(int id);
       
        void Save(Entities.Product product);
        void Save(Entities.News news);
        void Save(Entities.NewThings newThing);
        void Save(Entities.Discount discount);
    }
}
