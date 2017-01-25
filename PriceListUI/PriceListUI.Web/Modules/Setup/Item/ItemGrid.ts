
namespace PriceListUI.Setup {
    
    @Serenity.Decorators.registerClass()
    export class ItemGrid extends Serenity.EntityGrid<ItemRow, any> {
        protected getColumnsKey() { return 'Setup.Item'; }
        protected getDialogType() { return ItemDialog; }
        protected getIdProperty() { return ItemRow.idProperty; }
        protected getLocalTextPrefix() { return ItemRow.localTextPrefix; }
        protected getService() { return ItemService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}