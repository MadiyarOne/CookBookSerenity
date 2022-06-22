namespace BtsSerinCookBook.CookBook {
    export interface IngredientMeasuresForm {
        Name: Serenity.StringEditor;
    }

    export class IngredientMeasuresForm extends Serenity.PrefixedContext {
        static formKey = 'CookBook.IngredientMeasures';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!IngredientMeasuresForm.init)  {
                IngredientMeasuresForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(IngredientMeasuresForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
