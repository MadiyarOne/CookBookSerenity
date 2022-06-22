namespace BtsSerinCookBook.CookBook {
    export namespace RecipePartIngredientMeasuresService {
        export const baseUrl = 'CookBook/RecipePartIngredientMeasures';

        export declare function Create(request: Serenity.SaveRequest<RecipePartIngredientMeasuresRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<RecipePartIngredientMeasuresRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RecipePartIngredientMeasuresRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RecipePartIngredientMeasuresRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "CookBook/RecipePartIngredientMeasures/Create",
            Update = "CookBook/RecipePartIngredientMeasures/Update",
            Delete = "CookBook/RecipePartIngredientMeasures/Delete",
            Retrieve = "CookBook/RecipePartIngredientMeasures/Retrieve",
            List = "CookBook/RecipePartIngredientMeasures/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>RecipePartIngredientMeasuresService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
