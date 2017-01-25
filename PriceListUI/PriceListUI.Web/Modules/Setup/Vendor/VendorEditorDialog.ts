
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace PriceListUI.Setup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VendorEditorDialog extends Common.GridEditorDialog<VendorRow> {
        protected getFormKey() { return VendorForm.formKey; }
                protected getLocalTextPrefix() { return VendorRow.localTextPrefix; }
        protected getNameProperty() { return VendorRow.nameProperty; }
        protected form = new VendorForm(this.idPrefix);
    }
}