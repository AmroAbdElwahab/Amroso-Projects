
namespace PriceListUI.Setup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Setup.Item")]
    [BasedOnRow(typeof(Entities.ItemRow))]
    public class ItemForm
    {
        public Int32 UnitRecId { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
    }
}