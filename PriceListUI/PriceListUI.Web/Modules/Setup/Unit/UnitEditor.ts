
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace PriceListUI.Setup {
    
    @Serenity.Decorators.registerClass()
    export class UnitEditor extends Common.GridEditorBase<UnitRow> {
        protected getColumnsKey() { return 'Setup.Unit'; }
        protected getDialogType() { return UnitEditorDialog; }
                protected getLocalTextPrefix() { return UnitRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}