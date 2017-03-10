
namespace PriceListUI.Transactions {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PurchDialog extends Serenity.EntityDialog<PurchRow, any> {
        protected getFormKey() { return PurchForm.formKey; }
        protected getIdProperty() { return PurchRow.idProperty; }
        protected getLocalTextPrefix() { return PurchRow.localTextPrefix; }
        protected getNameProperty() { return PurchRow.nameProperty; }
        protected getService() { return PurchService.baseUrl; }

        protected form = new PurchForm(this.idPrefix);

    }
}