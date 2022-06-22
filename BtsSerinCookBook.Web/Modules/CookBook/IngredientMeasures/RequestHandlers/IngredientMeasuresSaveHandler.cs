using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<BtsSerinCookBook.CookBook.IngredientMeasuresRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BtsSerinCookBook.CookBook.IngredientMeasuresRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IIngredientMeasuresSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class IngredientMeasuresSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IIngredientMeasuresSaveHandler
    {
        public IngredientMeasuresSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}