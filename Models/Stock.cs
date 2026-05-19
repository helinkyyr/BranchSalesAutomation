using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BranchSalesAutomation.Models
{
    [Table("Stock")]
    internal class Stock
    {
        [Key]
        public int stock_id { get; set; }

        public int branch_id { get; set; }

        public int product_id { get; set; }

        public int quantity { get; set; }

        [ForeignKey("branch_id")]
        public virtual Branch Branch { get; set; }

        [ForeignKey("product_id")]
        public virtual Product Product { get; set; }
    }
}