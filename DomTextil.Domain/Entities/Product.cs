using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomTextil.Domain.Entities
{
    public class Product
    {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public string MainPhoto { get; set; }
            public string[] Photos { get; set; }
    }
   
}
