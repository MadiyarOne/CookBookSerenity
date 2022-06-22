using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BtsSerinCookBook.CookBook.RecipePartsRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipePartsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipePartsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRecipePartsDeleteHandler
    {
        public RecipePartsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}