using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace BtsSerinCookBook.CookBook.Pages
{

    [PageAuthorize(typeof(IngredientMeasuresRow))]
    public class IngredientMeasuresController : Controller
    {
        [Route("CookBook/IngredientMeasures")]
        public ActionResult Index()
        {
            return View("~/Modules/CookBook/IngredientMeasures/IngredientMeasuresIndex.cshtml");
        }
    }
}