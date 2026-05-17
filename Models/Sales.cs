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

        public int country_id { get; set; }

        public DateTime date { get; set; }

        public int stock_id { get; set; }

        public int salesquantity { get; set; }
    }    
        
         
}
