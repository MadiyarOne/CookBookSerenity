
namespace BtsSerinCookBook.CookBook {

    @Serenity.Decorators.registerClass()
    export class IngredientMeasuresGrid extends Serenity.EntityGrid<IngredientMeasuresRow, any> {
        protected getColumnsKey() { return IngredientMeasuresColumns.columnsKey; }
        protected getDialogType() { return IngredientMeasuresDialog; }
        protected getIdProperty() { return IngredientMeasuresRow.idProperty; }
        protected getInsertPermission() { return IngredientMeasuresRow.insertPermission; }
        protected getLocalTextPrefix() { return IngredientMeasuresRow.localTextPrefix; }
        protected getService() { return IngredientMeasuresService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}