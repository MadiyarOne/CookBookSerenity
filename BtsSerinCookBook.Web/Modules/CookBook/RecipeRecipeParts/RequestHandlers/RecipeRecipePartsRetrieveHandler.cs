using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BtsSerinCookBook.CookBook.RecipeRecipePartsRow>;
using MyRow = BtsSerinCookBook.CookBook.RecipeRecipePartsRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipeRecipePartsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeRecipePartsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeRecipePartsRetrieveHandler
    {
        public RecipeRecipePartsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}