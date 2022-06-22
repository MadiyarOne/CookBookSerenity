namespace BtsSerinCookBook.CookBook {
    export interface RecipePartsRow {
        RecipePartId?: number;
        Name?: string;
        RecipePartIngredientMeasureList?: number[];
    }

    export namespace RecipePartsRow {
        export const idProperty = 'RecipePartId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'CookBook.RecipeParts';
        export const lookupKey = 'CookBook.RecipeParts';

        export function getLookup(): Q.Lookup<RecipePartsRow> {
            return Q.getLookup<RecipePartsRow>('CookBook.RecipeParts');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            RecipePartId = "RecipePartId",
            Name = "Name",
            RecipePartIngredientMeasureList = "RecipePartIngredientMeasureList"
        }
    }
}
