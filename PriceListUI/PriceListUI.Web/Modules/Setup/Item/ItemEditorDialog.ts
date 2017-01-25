
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace PriceListUI.Setup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ItemEditorDialog extends Common.GridEditorDialog<ItemRow> {
        protected getFormKey() { return ItemForm.formKey; }
                protected getLocalTextPrefix() { return ItemRow.localTextPrefix; }
        protected getNameProperty() { return ItemRow.nameProperty; }
        protected form = new ItemForm(this.idPrefix);
    }
}