using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zovi_Fashion.Models
{
    public class Studio
    {
        [Key]                                               //Primary Key
        public int StudioID { get; set; }

        [Required]
        [StringLength(100)]                                             //String length used is 100
        public string Title { get; set; }

        [Required]
        [StringLength(1000)]                                    //Required
        public string StudioDesc { get; set; }

        public DateTime PostDate { get; set; }                                  //when is posted

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [NotMapped]
        public SingleFileUpload File { get; set; }
    }
}
