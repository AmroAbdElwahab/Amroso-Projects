
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace PriceListUI.Transactions {
    
    @Serenity.Decorators.registerClass()
    export class PurchEditor extends Common.GridEditorBase<PurchRow> {
        protected getColumnsKey() { return 'Transactions.Purch'; }
        protected getDialogType() { return PurchEditorDialog; }
                protected getLocalTextPrefix() { return PurchRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}