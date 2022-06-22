using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BtsSerinCookBook.CookBook.RecipePartIngredientMeasuresRow>;
using MyRow = BtsSerinCookBook.CookBook.RecipePartIngredientMeasuresRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipePartIngredientMeasuresListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipePartIngredientMeasuresListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRecipePartIngredientMeasuresListHandler
    {
        public RecipePartIngredientMeasuresListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}