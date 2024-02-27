using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
        public int CategoryDescription { get; set; }
        public bool Categorystatus { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
