

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Setup/Item", typeof(PriceListUI.Setup.Pages.ItemController))]

namespace PriceListUI.Setup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Setup/Item"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ItemRow))]
    public class ItemController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Setup/Item/ItemIndex.cshtml");
        }
    }
}