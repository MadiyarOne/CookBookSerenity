using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BtsSerinCookBook.CookBook.RecipePartsRow>;
using MyRow = BtsSerinCookBook.CookBook.RecipePartsRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipePartsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipePartsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRecipePartsListHandler
    {
        public RecipePartsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}