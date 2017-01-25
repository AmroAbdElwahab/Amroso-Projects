
namespace PriceListUI.Setup {
    
    @Serenity.Decorators.registerClass()
    export class UnitGrid extends Serenity.EntityGrid<UnitRow, any> {
        protected getColumnsKey() { return 'Setup.Unit'; }
        protected getDialogType() { return UnitDialog; }
        protected getIdProperty() { return UnitRow.idProperty; }
        protected getLocalTextPrefix() { return UnitRow.localTextPrefix; }
        protected getService() { return UnitService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}