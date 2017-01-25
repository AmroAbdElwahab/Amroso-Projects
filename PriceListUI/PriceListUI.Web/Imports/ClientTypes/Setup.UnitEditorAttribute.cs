using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PriceListUI.Setup
{
    public partial class UnitEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "PriceListUI.Setup.UnitEditor";

        public UnitEditorAttribute()
            : base(Key)
        {
        }
    }
}

