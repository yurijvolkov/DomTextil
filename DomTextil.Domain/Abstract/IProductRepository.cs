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

        void Save(Entities.Product product);
    }
}
