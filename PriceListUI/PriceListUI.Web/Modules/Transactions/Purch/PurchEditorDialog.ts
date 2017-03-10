
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace PriceListUI.Transactions {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PurchEditorDialog extends Common.GridEditorDialog<PurchRow> {
        protected getFormKey() { return PurchForm.formKey; }
                protected getLocalTextPrefix() { return PurchRow.localTextPrefix; }
        protected getNameProperty() { return PurchRow.nameProperty; }
        protected form = new PurchForm(this.idPrefix);
    }
}