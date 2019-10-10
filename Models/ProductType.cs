using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBazar.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="ProductType Name")]
        public string ProductTypeName { get; set; }
    }
}
