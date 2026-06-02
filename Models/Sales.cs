using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchSalesAutomation.Models
{
    [Table("Sales")]
    internal class Sales
    {
        [Key]
        public int sale_id { get; set; }

        public int stock_id { get; set; }

        public int quantity { get; set; }

        public DateTime sale_date { get; set; }

        public decimal unit_price { get; set; }

        public decimal total { get; set; }

        [ForeignKey("stock_id")]
        public virtual Stock Stock { get; set; }
    }
}
