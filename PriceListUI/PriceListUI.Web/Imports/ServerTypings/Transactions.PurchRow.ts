namespace PriceListUI.Transactions {
    export interface PurchRow {
        RecId?: number;
        VendorRecId?: number;
        Code?: string;
        Date?: string;
        Description?: string;
        Status?: Status;
        VendorRecAddress?: string;
        VendorRecCode?: string;
        VendorRecName?: string;
        VendorRecImage?: string;
    }

    export namespace PurchRow {
        export const idProperty = 'RecId';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Transactions.Purch';

        export namespace Fields {
            export declare const RecId: string;
            export declare const VendorRecId: string;
            export declare const Code: string;
            export declare const Date: string;
            export declare const Description: string;
            export declare const Status: string;
            export declare const VendorRecAddress: string;
            export declare const VendorRecCode: string;
            export declare const VendorRecName: string;
            export declare const VendorRecImage: string;
        }

        ['RecId', 'VendorRecId', 'Code', 'Date', 'Description', 'Status', 'VendorRecAddress', 'VendorRecCode', 'VendorRecName', 'VendorRecImage'].forEach(x => (<any>Fields)[x] = x);
    }
}

