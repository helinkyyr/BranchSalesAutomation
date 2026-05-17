using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BranchSalesAutomation.Models
{
    [Table("Countries")]
    internal class Country
    {
        [Key]
        public int country_id { get; set; }

        [Required]
        [MaxLength(100)]
        public string country_name { get; set; }
    }
}
