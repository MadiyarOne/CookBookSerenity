using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BtsSerinCookBook.CookBook.RecipePartsRow>;
using MyRow = BtsSerinCookBook.CookBook.RecipePartsRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipePartsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipePartsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipePartsRetrieveHandler
    {
        public RecipePartsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}