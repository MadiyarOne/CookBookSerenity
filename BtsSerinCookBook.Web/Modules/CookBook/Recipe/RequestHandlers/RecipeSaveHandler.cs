using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<BtsSerinCookBook.CookBook.RecipeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BtsSerinCookBook.CookBook.RecipeRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeSaveHandler
    {
        public RecipeSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}