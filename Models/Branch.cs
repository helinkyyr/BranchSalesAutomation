using System.Collections.Generic;
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

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}