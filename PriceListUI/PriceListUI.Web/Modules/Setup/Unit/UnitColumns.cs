
namespace PriceListUI.Setup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Setup.Unit")]
    [BasedOnRow(typeof(Entities.UnitRow))]
    public class UnitColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 RecId { get; set; }
        [EditLink]
        public String Code { get; set; }
        public String Name { get; set; }
    }
}