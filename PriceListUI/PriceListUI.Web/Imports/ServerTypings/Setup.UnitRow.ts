namespace PriceListUI.Setup {
    export interface UnitRow {
        RecId?: number;
        Code?: string;
        Name?: string;
    }

    export namespace UnitRow {
        export const idProperty = 'RecId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Setup.Unit';
        export const lookupKey = 'Setup.Unit';

        export function getLookup(): Q.Lookup<UnitRow> {
            return Q.getLookup<UnitRow>('Setup.Unit');
        }

        export namespace Fields {
            export declare const RecId: string;
            export declare const Code: string;
            export declare const Name: string;
        }

        ['RecId', 'Code', 'Name'].forEach(x => (<any>Fields)[x] = x);
    }
}

