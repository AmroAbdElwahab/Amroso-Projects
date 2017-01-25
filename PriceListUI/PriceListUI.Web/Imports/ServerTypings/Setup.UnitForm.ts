namespace PriceListUI.Setup {
    export class UnitForm extends Serenity.PrefixedContext {
        static formKey = 'Setup.Unit';

    }

    export interface UnitForm {
        Code: Serenity.StringEditor;
        Name: Serenity.StringEditor;
    }

    [['Code', () => Serenity.StringEditor], ['Name', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(UnitForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

