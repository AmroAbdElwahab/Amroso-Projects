

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Setup/Vendor", typeof(PriceListUI.Setup.Pages.VendorController))]

namespace PriceListUI.Setup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Setup/Vendor"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.VendorRow))]
    public class VendorController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Setup/Vendor/VendorIndex.cshtml");
        }
    }
}