
namespace PriceListUI.Transactions.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Transactions.Purch")]
    [BasedOnRow(typeof(Entities.PurchRow))]
    public class PurchColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 RecId { get; set; }
        public Int32 VendorRecId { get; set; }
        [EditLink]
        public String Code { get; set; }
        public DateTime Date { get; set; }
        public String Description { get; set; }
    }
}