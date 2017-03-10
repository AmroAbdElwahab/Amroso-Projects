
namespace PriceListUI.Transactions.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Transactions.Purch")]
    [BasedOnRow(typeof(Entities.PurchRow))]
    public class PurchForm
    {
        public Int32 VendorRecId { get; set; }
        public String Code { get; set; }
        public DateTime Date { get; set; }
        public String Description { get; set; }

        public Status Status { get; set; }
    }
}