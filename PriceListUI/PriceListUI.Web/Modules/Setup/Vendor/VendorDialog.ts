
namespace PriceListUI.Setup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VendorDialog extends Serenity.EntityDialog<VendorRow, any> {
        protected getFormKey() { return VendorForm.formKey; }
        protected getIdProperty() { return VendorRow.idProperty; }
        protected getLocalTextPrefix() { return VendorRow.localTextPrefix; }
        protected getNameProperty() { return VendorRow.nameProperty; }
        protected getService() { return VendorService.baseUrl; }

        protected form = new VendorForm(this.idPrefix);

    }
}