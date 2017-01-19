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

    public class Purch : EntityHeader
    {
        public Month Month { get; set; }

        public int Year { get; set; }

        public int VendorRecId { get; set; }

        [ForeignKey("VendorRecId")]
        public virtual Vendor Vendor { get; set; }   
    }

    public class PurchItem : EntityLineRef
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