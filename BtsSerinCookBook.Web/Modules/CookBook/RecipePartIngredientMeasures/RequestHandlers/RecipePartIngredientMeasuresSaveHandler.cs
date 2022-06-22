using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<BtsSerinCookBook.CookBook.RecipePartIngredientMeasuresRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BtsSerinCookBook.CookBook.RecipePartIngredientMeasuresRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipePartIngredientMeasuresSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipePartIngredientMeasuresSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipePartIngredientMeasuresSaveHandler
    {
        public RecipePartIngredientMeasuresSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}