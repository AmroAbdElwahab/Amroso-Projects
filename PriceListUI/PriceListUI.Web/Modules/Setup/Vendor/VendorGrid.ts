
namespace PriceListUI.Setup {
    
    @Serenity.Decorators.registerClass()
    export class VendorGrid extends Serenity.EntityGrid<VendorRow, any> {
        protected getColumnsKey() { return 'Setup.Vendor'; }
        protected getDialogType() { return VendorDialog; }
        protected getIdProperty() { return VendorRow.idProperty; }
        protected getLocalTextPrefix() { return VendorRow.localTextPrefix; }
        protected getService() { return VendorService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}