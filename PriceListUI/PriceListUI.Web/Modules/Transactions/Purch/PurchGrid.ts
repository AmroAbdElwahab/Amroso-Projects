
namespace PriceListUI.Transactions {
    
    @Serenity.Decorators.registerClass()
    export class PurchGrid extends Serenity.EntityGrid<PurchRow, any> {
        protected getColumnsKey() { return 'Transactions.Purch'; }
        protected getDialogType() { return PurchDialog; }
        protected getIdProperty() { return PurchRow.idProperty; }
        protected getLocalTextPrefix() { return PurchRow.localTextPrefix; }
        protected getService() { return PurchService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}