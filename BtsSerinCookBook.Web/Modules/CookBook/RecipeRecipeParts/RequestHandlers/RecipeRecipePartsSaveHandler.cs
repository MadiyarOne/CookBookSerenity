using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<BtsSerinCookBook.CookBook.RecipeRecipePartsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BtsSerinCookBook.CookBook.RecipeRecipePartsRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipeRecipePartsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeRecipePartsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeRecipePartsSaveHandler
    {
        public RecipeRecipePartsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}