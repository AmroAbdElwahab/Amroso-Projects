
namespace PriceListUI.Setup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Setup.Vendor")]
    [BasedOnRow(typeof(Entities.VendorRow))]
    public class VendorColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,Hidden]
        public Int32 RecId { get; set; }

        [EditLink]
        public String Code { get; set; }

        [EditLink]
        public String Name { get; set; }
        
        public String Address { get; set; }
    }
}