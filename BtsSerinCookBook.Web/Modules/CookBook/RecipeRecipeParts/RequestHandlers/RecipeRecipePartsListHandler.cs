using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BtsSerinCookBook.CookBook.RecipeRecipePartsRow>;
using MyRow = BtsSerinCookBook.CookBook.RecipeRecipePartsRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipeRecipePartsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeRecipePartsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeRecipePartsListHandler
    {
        public RecipeRecipePartsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}