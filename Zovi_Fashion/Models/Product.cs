using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zovi_Fashion.Models
{
    public class Product
    {
        [Key]                                               //Primary key used for products
        public int ProductID { get; set; }

        [Required]
        [StringLength(200)]                                     //string length is 200
        public string ProductName { get; set; }

        [StringLength(400)]
        public string Fabric { get; set; }                              //Fabric name

        [StringLength(400)]
        public string ManufacturingYear { get; set; }                           //what year is manufacturing

        [StringLength(400)]
        public string Description { get; set; }

        [StringLength(400)]
        public string Color { get; set; }                               //Colour of cloth
        [StringLength(400)]
        public string Fit { get; set; }                                         //Men or women

        [StringLength(400)]
        public string SleveLength { get; set; }

        [StringLength(400)]
        public string Occasion { get; set; }                                                //What occasion 

        [StringLength(400)]
        public string PatternType { get; set; }

        [StringLength(400)]
        public string Size { get; set; }                                                //Size of clothes

        [StringLength(400)]
        public string Neck { get; set; }

        [StringLength(400)]
        public string WashCare { get; set; }

        [StringLength(400)]
        public string SoldBy { get; set; }

        [StringLength(400)]
        public string Price { get; set; }                                       //Price of cloth

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [Required]
        public int BrandID { get; set; }

        [ForeignKey("BrandID")]
        [InverseProperty("BrandProducts")]
        public virtual Brand Brand { get; set; }

        public virtual ICollection<ProductReview> ProductReviews { get; set; }

        [NotMapped]
        public SingleFileUpload File { get; set; }                                  //Upload file
    }

    public class SingleFileUpload
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
    }
}
