namespace BtsSerinCookBook.CookBook {
    export namespace IngredientMeasuresService {
        export const baseUrl = 'CookBook/IngredientMeasures';

        export declare function Create(request: Serenity.SaveRequest<IngredientMeasuresRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<IngredientMeasuresRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<IngredientMeasuresRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<IngredientMeasuresRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "CookBook/IngredientMeasures/Create",
            Update = "CookBook/IngredientMeasures/Update",
            Delete = "CookBook/IngredientMeasures/Delete",
            Retrieve = "CookBook/IngredientMeasures/Retrieve",
            List = "CookBook/IngredientMeasures/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>IngredientMeasuresService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
