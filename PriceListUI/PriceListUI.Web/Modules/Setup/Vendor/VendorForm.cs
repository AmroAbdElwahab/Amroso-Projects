
namespace PriceListUI.Setup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Setup.Vendor")]
    [BasedOnRow(typeof(Entities.VendorRow))]
    public class VendorForm
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
    }
}