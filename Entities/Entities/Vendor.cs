using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceList.Models
{
    public class Vendor
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int RecId { get; set; }

        [DisplayName("معرف المورد")]
        [Column(Order = 1)]
        [Required(ErrorMessage = "يجب تحديد معرف المورد")]
        public string Code { get; set; }

        [DisplayName("أسم المورد")]
        [Column(Order = 2)]
        [Required(ErrorMessage = "يجب تحديد أسم المورد")]
        public string Name { get; set; }

        [DisplayName("عنوان المورد")]
        [Column(Order = 3)]
        public string Address { get; set; }
    }
}