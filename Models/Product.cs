using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchSalesAutomation.Models
{
    [Table("Product")]
    internal class Product
    {
        [Key]
        public int product_id { get; set; }

        [Required]
        [MaxLength(100)]
        public string product_name { get; set; }

        public decimal product_price { get; set; }

        [Required]
        public int category_id { get; set; }
    }
}
