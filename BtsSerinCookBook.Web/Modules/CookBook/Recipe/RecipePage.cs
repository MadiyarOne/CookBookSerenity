using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace BtsSerinCookBook.CookBook.Pages
{

    [PageAuthorize(typeof(RecipeRow))]
    public class RecipeController : Controller
    {
        [Route("CookBook/Recipe")]
        public ActionResult Index()
        {
            return View("~/Modules/CookBook/Recipe/RecipeIndex.cshtml");
        }
    }
}