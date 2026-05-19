using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("category_id")]
        public virtual Category Category { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}