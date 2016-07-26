using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DomTextil.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        static string connectionString = "Data Source=ms-sql-8.in-solve.ru;Initial Catalog=1gb_textiledb1;Persist Security Info=True;User ID=1gb_textilehouse;Password=5f54a4f8ty";
        public EFDbContext () 
            : base(connectionString) { }
        
        
        public DbSet<Entities.Product> Products { get; set; }
        public DbSet<Entities.News> News { get; set; }
        public DbSet<Entities.Discount> Discount { get; set; }
        public DbSet<Entities.NewThings> NewThings { get; set; }
    }
}
