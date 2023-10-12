using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EfCoreCodeFirst.Entities
{
    [Table("ProductTb")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
       
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Barcode { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}

/**
 * ? : nullable anlamına gelir. Design time'da nullable olmasına rağmen runtime'da nullable olmayabilir.
*/