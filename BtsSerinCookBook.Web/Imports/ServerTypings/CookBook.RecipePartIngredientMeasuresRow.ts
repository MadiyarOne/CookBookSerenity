namespace BtsSerinCookBook.CookBook {
    export interface RecipePartIngredientMeasuresRow {
        RecipeIngredientMeasureId?: number;
        RecipeId?: number;
        IngredientMeasureId?: number;
        RecipeName?: string;
        IngredientMeasureName?: string;
    }

    export namespace RecipePartIngredientMeasuresRow {
        export const idProperty = 'RecipeIngredientMeasureId';
        export const localTextPrefix = 'CookBook.RecipePartIngredientMeasures';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            RecipeIngredientMeasureId = "RecipeIngredientMeasureId",
            RecipeId = "RecipeId",
            IngredientMeasureId = "IngredientMeasureId",
            RecipeName = "RecipeName",
            IngredientMeasureName = "IngredientMeasureName"
        }
    }
}
