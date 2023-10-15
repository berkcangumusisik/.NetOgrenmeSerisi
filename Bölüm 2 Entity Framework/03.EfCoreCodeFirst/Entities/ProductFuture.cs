using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EfCoreCodeFirst.Entities
{
    public class ProductFuture
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }
        public int ProductId { get; set; } // Foreign Key
        public Product Product { get; set; }
    }
}
