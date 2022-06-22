using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BtsSerinCookBook.CookBook.RecipePartIngredientMeasuresRow>;
using MyRow = BtsSerinCookBook.CookBook.RecipePartIngredientMeasuresRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipePartIngredientMeasuresRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipePartIngredientMeasuresRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipePartIngredientMeasuresRetrieveHandler
    {
        public RecipePartIngredientMeasuresRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}