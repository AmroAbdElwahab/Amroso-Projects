

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Transactions/Purch", typeof(PriceListUI.Transactions.Pages.PurchController))]

namespace PriceListUI.Transactions.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Transactions/Purch"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PurchRow))]
    public class PurchController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Transactions/Purch/PurchIndex.cshtml");
        }
    }
}