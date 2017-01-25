namespace PriceListUI.Setup {
    export interface VendorRow {
        RecId?: number;
        Code?: string;
        Name?: string;
        Address?: string;
    }

    export namespace VendorRow {
        export const idProperty = 'RecId';
        export const nameProperty = 'Address';
        export const localTextPrefix = 'Setup.Vendor';

        export namespace Fields {
            export declare const RecId: string;
            export declare const Code: string;
            export declare const Name: string;
            export declare const Address: string;
        }

        ['RecId', 'Code', 'Name', 'Address'].forEach(x => (<any>Fields)[x] = x);
    }
}

