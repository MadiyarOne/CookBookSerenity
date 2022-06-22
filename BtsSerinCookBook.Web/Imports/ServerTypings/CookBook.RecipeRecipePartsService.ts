namespace BtsSerinCookBook.CookBook {
    export namespace RecipeRecipePartsService {
        export const baseUrl = 'CookBook/RecipeRecipeParts';

        export declare function Create(request: Serenity.SaveRequest<RecipeRecipePartsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<RecipeRecipePartsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RecipeRecipePartsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RecipeRecipePartsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "CookBook/RecipeRecipeParts/Create",
            Update = "CookBook/RecipeRecipeParts/Update",
            Delete = "CookBook/RecipeRecipeParts/Delete",
            Retrieve = "CookBook/RecipeRecipeParts/Retrieve",
            List = "CookBook/RecipeRecipeParts/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>RecipeRecipePartsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
