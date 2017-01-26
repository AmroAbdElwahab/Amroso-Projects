using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PriceList.BaseEntities;
using PriceList.Enums;

namespace PriceList.Models
{
    [Table("Purch", Schema = "Transactions")]
    public class Purch : TransEntityHeader
    {
        public int VendorRecId { get; set; }

        [ForeignKey("VendorRecId")]
        public virtual Vendor Vendor { get; set; }   
    }

    [Table("PurchItem", Schema = "Transactions")]
    public class PurchItem : TransEntityLineRef
    {
        [ForeignKey("ParentRecId")]
        public virtual Purch Purch { get; set; }

        [ForeignKey("ChiledRecId")]
        public virtual Item Item { get; set; }

        public decimal Qty { get; set; }

        public decimal Price { get; set; }

        public decimal Amount { get { return this.Price * this.Qty; } }
    }
}