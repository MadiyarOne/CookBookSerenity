using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BtsSerinCookBook.CookBook.IngredientMeasuresRow>;
using MyRow = BtsSerinCookBook.CookBook.IngredientMeasuresRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IIngredientMeasuresListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class IngredientMeasuresListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IIngredientMeasuresListHandler
    {
        public IngredientMeasuresListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}