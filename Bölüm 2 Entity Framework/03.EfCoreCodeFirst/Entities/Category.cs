using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EfCoreCodeFirst.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<Product> Products { get; set; }
    }
}


/**
 * One to One : Bir ürünün bir özelliği olabilir. Örneğin bir ürünün boyutu olabilir.
 * One to Many : Bir kategorinin birden fazla ürünü olabilir.
 * Many to Many : Bir ürünün birden fazla kategorisi olabilir.
 */