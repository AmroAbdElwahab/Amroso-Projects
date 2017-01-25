
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace PriceListUI.Setup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class UnitEditorDialog extends Common.GridEditorDialog<UnitRow> {
        protected getFormKey() { return UnitForm.formKey; }
                protected getLocalTextPrefix() { return UnitRow.localTextPrefix; }
        protected getNameProperty() { return UnitRow.nameProperty; }
        protected form = new UnitForm(this.idPrefix);
    }
}