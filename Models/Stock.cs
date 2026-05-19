using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchSalesAutomation.Models
{
    [Table("Stocks")]
    internal class Stock
    {
        [Key]
        public int stock_id { get; set; }

        [Required]
        public int branch_id { get; set; }
        [Required]  
        public int product_id { get; set; }
        [Required]
        public int quantity { get; set; }
        [ForeignKey("product_id")]
        public virtual Product Product { get; set; }

        [ForeignKey("branch_id")]
        public virtual Branch Branch { get; set; }
    }
}
