namespace PriceListUI.Transactions {
    export class PurchForm extends Serenity.PrefixedContext {
        static formKey = 'Transactions.Purch';

    }

    export interface PurchForm {
        VendorRecId: Serenity.IntegerEditor;
        Code: Serenity.StringEditor;
        Date: Serenity.DateEditor;
        Description: Serenity.StringEditor;
        Status: Serenity.EnumEditor;
    }

    [['VendorRecId', () => Serenity.IntegerEditor], ['Code', () => Serenity.StringEditor], ['Date', () => Serenity.DateEditor], ['Description', () => Serenity.StringEditor], ['Status', () => Serenity.EnumEditor]].forEach(x => Object.defineProperty(PurchForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

