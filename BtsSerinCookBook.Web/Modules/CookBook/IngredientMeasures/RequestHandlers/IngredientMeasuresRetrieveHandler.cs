using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BtsSerinCookBook.CookBook.IngredientMeasuresRow>;
using MyRow = BtsSerinCookBook.CookBook.IngredientMeasuresRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IIngredientMeasuresRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class IngredientMeasuresRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IIngredientMeasuresRetrieveHandler
    {
        public IngredientMeasuresRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}