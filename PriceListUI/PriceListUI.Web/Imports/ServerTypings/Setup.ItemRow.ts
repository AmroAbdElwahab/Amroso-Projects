namespace PriceListUI.Setup {
    export interface ItemRow {
        RecId?: number;
        UnitRecId?: number;
        Code?: string;
        Name?: string;
        UnitRecCode?: string;
        UnitRecName?: string;
    }

    export namespace ItemRow {
        export const idProperty = 'RecId';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Setup.Item';

        export namespace Fields {
            export declare const RecId: string;
            export declare const UnitRecId: string;
            export declare const Code: string;
            export declare const Name: string;
            export declare const UnitRecCode: string;
            export declare const UnitRecName: string;
        }

        ['RecId', 'UnitRecId', 'Code', 'Name', 'UnitRecCode', 'UnitRecName'].forEach(x => (<any>Fields)[x] = x);
    }
}

