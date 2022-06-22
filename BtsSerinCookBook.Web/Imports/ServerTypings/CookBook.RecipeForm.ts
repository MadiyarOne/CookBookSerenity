namespace BtsSerinCookBook.CookBook {
    export interface RecipeForm {
        Title: Serenity.StringEditor;
        InputDateTime: Serenity.DateEditor;
        Description: Serenity.TextAreaEditor;
        PhotoUrl: Serenity.ImageUploadEditor;
        CookDescription: Serenity.TextAreaEditor;
        RecipePartList: Serenity.LookupEditor;
    }

    export class RecipeForm extends Serenity.PrefixedContext {
        static formKey = 'CookBook.Recipe';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RecipeForm.init)  {
                RecipeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.TextAreaEditor;
                var w3 = s.ImageUploadEditor;
                var w4 = s.LookupEditor;

                Q.initFormType(RecipeForm, [
                    'Title', w0,
                    'InputDateTime', w1,
                    'Description', w2,
                    'PhotoUrl', w3,
                    'CookDescription', w2,
                    'RecipePartList', w4
                ]);
            }
        }
    }
}
