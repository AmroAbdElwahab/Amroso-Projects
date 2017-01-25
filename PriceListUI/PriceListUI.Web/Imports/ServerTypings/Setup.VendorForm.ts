namespace PriceListUI.Setup {
    export class VendorForm extends Serenity.PrefixedContext {
        static formKey = 'Setup.Vendor';

    }

    export interface VendorForm {
        Code: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Address: Serenity.TextAreaEditor;
        Image: Serenity.ImageUploadEditor;
    }

    [['Code', () => Serenity.StringEditor], ['Name', () => Serenity.StringEditor], ['Address', () => Serenity.TextAreaEditor], ['Image', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(VendorForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

