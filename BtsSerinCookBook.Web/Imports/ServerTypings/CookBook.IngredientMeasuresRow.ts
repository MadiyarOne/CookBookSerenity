namespace BtsSerinCookBook.CookBook {
    export interface IngredientMeasuresRow {
        IngredientMeasureId?: number;
        Name?: string;
    }

    export namespace IngredientMeasuresRow {
        export const idProperty = 'IngredientMeasureId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'CookBook.IngredientMeasures';
        export const lookupKey = 'CookBook.IngredientMeasures';

        export function getLookup(): Q.Lookup<IngredientMeasuresRow> {
            return Q.getLookup<IngredientMeasuresRow>('CookBook.IngredientMeasures');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            IngredientMeasureId = "IngredientMeasureId",
            Name = "Name"
        }
    }
}
