using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zovi_Fashion.Models
{
    public class ProductReview
    {
        [Key]                                                   //Primary key
        public int ReviewID { get; set; }

        [Required]                                                      //Required
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Rating { get; set; }                                            //Rating of product

        [Required]
        [StringLength(1000)]
        public string ReviewText { get; set; }                                      //Review of product

        [Required]
        public int ProductID { get; set; }                                      //Product id foreign key

        public Product Product { get; set; }                                                

        public DateTime ReviewDate { get; set; }

    }
}
