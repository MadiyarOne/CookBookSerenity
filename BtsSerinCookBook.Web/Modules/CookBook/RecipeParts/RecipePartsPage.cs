using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace BtsSerinCookBook.CookBook.Pages
{

    [PageAuthorize(typeof(RecipePartsRow))]
    public class RecipePartsController : Controller
    {
        [Route("CookBook/RecipeParts")]
        public ActionResult Index()
        {
            return View("~/Modules/CookBook/RecipeParts/RecipePartsIndex.cshtml");
        }
    }
}