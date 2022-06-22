using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BtsSerinCookBook.CookBook.RecipeRecipePartsRow;

namespace BtsSerinCookBook.CookBook
{
    public interface IRecipeRecipePartsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeRecipePartsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeRecipePartsDeleteHandler
    {
        public RecipeRecipePartsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}