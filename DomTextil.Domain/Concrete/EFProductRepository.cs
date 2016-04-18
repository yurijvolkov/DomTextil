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
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }

        public void Save(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
