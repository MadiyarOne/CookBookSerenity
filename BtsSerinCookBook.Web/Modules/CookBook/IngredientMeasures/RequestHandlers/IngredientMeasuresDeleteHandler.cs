using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BtsSerinCookBook.CookBook.IngredientMeasuresRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IIngredientMeasuresDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class IngredientMeasuresDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IIngredientMeasuresDeleteHandler
    {
        public IngredientMeasuresDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}