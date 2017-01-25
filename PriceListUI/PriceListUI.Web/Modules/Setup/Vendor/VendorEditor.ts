
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace PriceListUI.Setup {
    
    @Serenity.Decorators.registerClass()
    export class VendorEditor extends Common.GridEditorBase<VendorRow> {
        protected getColumnsKey() { return 'Setup.Vendor'; }
        protected getDialogType() { return VendorEditorDialog; }
                protected getLocalTextPrefix() { return VendorRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}