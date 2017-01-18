using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceList.Models
{
    public class Unit
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int RecId { get; set; }

        [DisplayName("معرف الوحدة")]
        [Column(Order = 1)]
        [Required(ErrorMessage = "يجب تحديد معرف الوحدة")]
        public string Code { get; set; }

        [DisplayName("أسم الوحدة")]
        [Column(Order = 2)]
        [Required(ErrorMessage = "يجب تحديد أسم الوحدة")]
        public string Name { get; set; }
    }
}