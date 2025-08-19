using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Auctions.Auction.Controllers
{
    [Area(AreaNames.ADMIN)]
    public class AuctionsAdminController : BasePluginController
    {
        public IActionResult List()
        {
            return View("~/Plugins/Auctions.Auction/Views/Admin/List.cshtml");
        }
    }
}
