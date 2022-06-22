namespace BtsSerinCookBook.CookBook {
    export interface RecipePartsForm {
        Name: Serenity.StringEditor;
        RecipePartIngredientMeasureList: Serenity.LookupEditor;
    }

    export class RecipePartsForm extends Serenity.PrefixedContext {
        static formKey = 'CookBook.RecipeParts';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RecipePartsForm.init)  {
                RecipePartsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(RecipePartsForm, [
                    'Name', w0,
                    'RecipePartIngredientMeasureList', w1
                ]);
            }
        }
    }
}
