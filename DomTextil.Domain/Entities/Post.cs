using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomTextil.Domain.Entities
{
    public class Post : IEqualityComparer<Post>
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public DateTime PublisTime { get; set; }

        public bool Equals(Post x, Post y)
        {
            if (x.PublisTime < y.PublisTime)
                return false;
            return true;
        }

        public int GetHashCode(Post obj)
        {
            throw new NotImplementedException();
        }
    }
}
