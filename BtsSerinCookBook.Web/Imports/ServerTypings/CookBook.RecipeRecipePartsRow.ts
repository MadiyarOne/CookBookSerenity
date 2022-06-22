namespace BtsSerinCookBook.CookBook {
    export interface RecipeRecipePartsRow {
        RecipeRecipePartId?: number;
        RecipeId?: number;
        RecipePartId?: number;
        RecipeTitle?: string;
        RecipeInputDateTime?: string;
        RecipeDescription?: string;
        RecipePhotoUrl?: string;
        RecipeCookDescription?: string;
        RecipePartName?: string;
    }

    export namespace RecipeRecipePartsRow {
        export const idProperty = 'RecipeRecipePartId';
        export const localTextPrefix = 'CookBook.RecipeRecipeParts';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            RecipeRecipePartId = "RecipeRecipePartId",
            RecipeId = "RecipeId",
            RecipePartId = "RecipePartId",
            RecipeTitle = "RecipeTitle",
            RecipeInputDateTime = "RecipeInputDateTime",
            RecipeDescription = "RecipeDescription",
            RecipePhotoUrl = "RecipePhotoUrl",
            RecipeCookDescription = "RecipeCookDescription",
            RecipePartName = "RecipePartName"
        }
    }
}
