using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BtsSerinCookBook.CookBook.RecipePartIngredientMeasuresRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipePartIngredientMeasuresDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipePartIngredientMeasuresDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRecipePartIngredientMeasuresDeleteHandler
    {
        public RecipePartIngredientMeasuresDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}