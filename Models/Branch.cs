using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BranchSalesAutomation.Models
{
    [Table("Branches")]
    internal class Branch
    {
        [Key]
        public int branch_id { get; set; }

        [Required]
        [StringLength(100)]
        public string branch_name { get; set; }

     
    }
}
