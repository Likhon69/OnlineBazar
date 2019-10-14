using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBazar.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [Display(Name ="Available")]
        public bool IsAvailabe { get; set; }
        public string Image { get; set; }
        [Required]
        [Display(Name ="Product Color")]
        public string ProductColor { get; set; }
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductType ProductType { get; set; }
        public int SpecialTagId { get; set; }
        [ForeignKey("SpecialTagId")]
        [Display(Name ="Product Tag")]
        public SpecialTag SpecialTag { get; set; }

    }
}
