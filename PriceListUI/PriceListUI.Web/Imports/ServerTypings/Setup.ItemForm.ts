namespace PriceListUI.Setup {
    export class ItemForm extends Serenity.PrefixedContext {
        static formKey = 'Setup.Item';

    }

    export interface ItemForm {
        Code: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        UnitRecId: Serenity.LookupEditor;
    }

    [['Code', () => Serenity.StringEditor], ['Name', () => Serenity.StringEditor], ['UnitRecId', () => Serenity.LookupEditor]].forEach(x => Object.defineProperty(ItemForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

