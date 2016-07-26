using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomTextil.Domain.Entities
{
    public struct TransferHelp
    {
        public string Main { get; set; }
        public List<string> Secondary { get; set; } 
        public IEnumerable<string> secondary2 { get; set; }
    }
    
}
