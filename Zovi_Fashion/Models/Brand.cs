using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zovi_Fashion.Models
{
    public class Brand
    {
        [Key]               //Primary key used for Brand
        public int BrandID { get; set; }

        [Required]
        [StringLength(100)]                 //String Length
        public string BrandName { get; set; }

        public virtual ICollection<Product> BrandProducts { get; set; }
    }
}
