using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<BtsSerinCookBook.CookBook.RecipePartsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BtsSerinCookBook.CookBook.RecipePartsRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipePartsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipePartsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipePartsSaveHandler
    {
        public RecipePartsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}