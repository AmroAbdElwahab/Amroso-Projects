using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PriceList.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int RecId { get; set; }

        [DisplayName("معرف الصنف")]
        [Column(Order = 1)]
        [Required(ErrorMessage = "يجب تحديد معرف الصنف")]
        public string Code { get; set; }

        [DisplayName("أسم الصنف")]
        [Column(Order = 2)]
        [Required(ErrorMessage = "يجب تحديد أسم الصنف")] 
        public string Name { get; set; }

        [DisplayName("معرف الوحدة")]
        [Column(Order = 3)]
        [Required(ErrorMessage = "يجب تحديد وحدة الصنف")]
        public int UnitId { get; set; }
        

        [ForeignKey("UnitId")]
        public virtual Unit Unit { get; set; }        

    }
}