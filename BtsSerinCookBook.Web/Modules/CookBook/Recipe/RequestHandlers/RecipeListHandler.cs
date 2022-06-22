using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BtsSerinCookBook.CookBook.RecipeRow>;
using MyRow = BtsSerinCookBook.CookBook.RecipeRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeListHandler
    {
        public RecipeListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}