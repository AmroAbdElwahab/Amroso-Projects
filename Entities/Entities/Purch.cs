using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceList.Models
{
    public enum Month
    {
        يناير   = 1,
        فبراير  = 2,
        مارس    = 3,
        أبريل   = 4,
        مايو    = 5,
        يونيو   = 6,
        يوليو   = 7,
        أغسطس   = 8,
        سبتمبر  = 9,
        أكتوبر  = 10,
        نوفمبر  = 11,
        ديسمبر  = 12
    }
    public class Purch
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int RecId { get; set; }

        [DisplayName("معرف الحركة")]
        [Column(Order = 1)]
        [Required(ErrorMessage = "يجب تحديد معرف الحركة")]
        public string Code { get; set; }

        [DisplayName("الشهر")]
        [Column(Order = 2)]
        [Required(ErrorMessage = "يجب تحديد الشهر")]
        public Month Month { get; set; }

        [DisplayName("السنة")]
        [Column(Order = 3)]
        [Required(ErrorMessage = "يجب تحديد السنة")]
        public int Year { get; set; }

        public virtual IEnumerable<PurchItems> PurchItems { get; set; }
    }

    public class PurchItems
    {
        [Key]
        [DisplayName("حركة الشراء")]
        [Column(Order = 1)]
        public virtual Purch Purch { get; set; } 

        [Key]
        [DisplayName("الصنف")]
        [Column(Order = 2)]
        public int ItemRecId { get; set; }
        [ForeignKey("ItemRecId")]
        public Item Item { get; set; }

        [DisplayName("الكميه")]
        [Column(Order = 3)]
        public decimal Qty { get; set; }

        [DisplayName("السعر")]
        [Column(Order = 4)]
        public decimal Price { get; set; }

        [DisplayName("القيمة")]
        [Column(Order = 5)]
        public decimal Amount { get { return this.Price * this.Qty; } }
    }
}