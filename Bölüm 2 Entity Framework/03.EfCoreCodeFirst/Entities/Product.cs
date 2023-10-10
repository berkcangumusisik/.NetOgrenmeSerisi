using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EfCoreCodeFirst.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Barcode { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
