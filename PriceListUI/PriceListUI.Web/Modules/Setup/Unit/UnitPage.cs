

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Setup/Unit", typeof(PriceListUI.Setup.Pages.UnitController))]

namespace PriceListUI.Setup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Setup/Unit"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.UnitRow))]
    public class UnitController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Setup/Unit/UnitIndex.cshtml");
        }
    }
}