namespace BtsSerinCookBook.CookBook {
    export interface RecipeRow {
        RecipeId?: number;
        Title?: string;
        InputDateTime?: string;
        Description?: string;
        PhotoUrl?: string;
        CookDescription?: string;
        RecipePartList?: number[];
    }

    export namespace RecipeRow {
        export const idProperty = 'RecipeId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'CookBook.Recipe';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            RecipeId = "RecipeId",
            Title = "Title",
            InputDateTime = "InputDateTime",
            Description = "Description",
            PhotoUrl = "PhotoUrl",
            CookDescription = "CookDescription",
            RecipePartList = "RecipePartList"
        }
    }
}
