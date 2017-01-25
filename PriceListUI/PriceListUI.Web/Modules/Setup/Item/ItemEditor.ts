
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace PriceListUI.Setup {
    
    @Serenity.Decorators.registerClass()
    export class ItemEditor extends Common.GridEditorBase<ItemRow> {
        protected getColumnsKey() { return 'Setup.Item'; }
        protected getDialogType() { return ItemEditorDialog; }
                protected getLocalTextPrefix() { return ItemRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}