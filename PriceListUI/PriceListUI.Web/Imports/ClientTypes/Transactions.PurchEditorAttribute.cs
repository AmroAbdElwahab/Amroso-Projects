using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PriceListUI.Transactions
{
    public partial class PurchEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "PriceListUI.Transactions.PurchEditor";

        public PurchEditorAttribute()
            : base(Key)
        {
        }
    }
}

