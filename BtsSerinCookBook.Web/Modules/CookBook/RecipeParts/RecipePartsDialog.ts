
namespace BtsSerinCookBook.CookBook {

    @Serenity.Decorators.registerClass()
    export class RecipePartsDialog extends Serenity.EntityDialog<RecipePartsRow, any> {
        protected getFormKey() { return RecipePartsForm.formKey; }
        protected getIdProperty() { return RecipePartsRow.idProperty; }
        protected getLocalTextPrefix() { return RecipePartsRow.localTextPrefix; }
        protected getNameProperty() { return RecipePartsRow.nameProperty; }
        protected getService() { return RecipePartsService.baseUrl; }
        protected getDeletePermission() { return RecipePartsRow.deletePermission; }
        protected getInsertPermission() { return RecipePartsRow.insertPermission; }
        protected getUpdatePermission() { return RecipePartsRow.updatePermission; }

        protected form = new RecipePartsForm(this.idPrefix);

    }
}