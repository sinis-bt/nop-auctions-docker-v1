using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Auctions.Auction.Controllers
{
    public class AuctionsController : BasePluginController
    {
        public IActionResult Index()
        {
            return View("~/Plugins/Auctions.Auction/Views/Public/Index.cshtml");
        }
    }
}
