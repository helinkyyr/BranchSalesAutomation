using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BranchSalesAutomation.Models
{
    [Table("Categories")]
    internal class Category
    {
        [Key]
        public int category_id { get; set; }

        [Required]
        [MaxLength(100)]
        public string category_name { get; set; }
    }


}
