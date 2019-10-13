
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBazar.Models
{
    public class SpecialTag
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Product Tag Name")]
        public string SpecialTagName { get; set; }
    }
}
