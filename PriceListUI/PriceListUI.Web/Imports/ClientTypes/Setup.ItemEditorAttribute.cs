using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PriceListUI.Setup
{
    public partial class ItemEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "PriceListUI.Setup.ItemEditor";

        public ItemEditorAttribute()
            : base(Key)
        {
        }
    }
}

