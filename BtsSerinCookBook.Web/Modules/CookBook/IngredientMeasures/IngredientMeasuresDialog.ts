
namespace BtsSerinCookBook.CookBook {

    @Serenity.Decorators.registerClass()
    export class IngredientMeasuresDialog extends Serenity.EntityDialog<IngredientMeasuresRow, any> {
        protected getFormKey() { return IngredientMeasuresForm.formKey; }
        protected getIdProperty() { return IngredientMeasuresRow.idProperty; }
        protected getLocalTextPrefix() { return IngredientMeasuresRow.localTextPrefix; }
        protected getNameProperty() { return IngredientMeasuresRow.nameProperty; }
        protected getService() { return IngredientMeasuresService.baseUrl; }
        protected getDeletePermission() { return IngredientMeasuresRow.deletePermission; }
        protected getInsertPermission() { return IngredientMeasuresRow.insertPermission; }
        protected getUpdatePermission() { return IngredientMeasuresRow.updatePermission; }

        protected form = new IngredientMeasuresForm(this.idPrefix);

    }
}