
namespace BtsSerinCookBook.CookBook {

    @Serenity.Decorators.registerClass()
    export class RecipePartsGrid extends Serenity.EntityGrid<RecipePartsRow, any> {
        protected getColumnsKey() { return RecipePartsColumns.columnsKey; }
        protected getDialogType() { return RecipePartsDialog; }
        protected getIdProperty() { return RecipePartsRow.idProperty; }
        protected getInsertPermission() { return RecipePartsRow.insertPermission; }
        protected getLocalTextPrefix() { return RecipePartsRow.localTextPrefix; }
        protected getService() { return RecipePartsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}