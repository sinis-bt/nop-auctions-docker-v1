using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Auctions.Auction.Models.Admin;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using System.Collections.Generic;

namespace Nop.Plugin.Auctions.Auction.Controllers
{
    [Area(AreaNames.ADMIN)]
    [AuthorizeAdmin]
    public class AuctionsAdminController : BasePluginController
    {
        public IActionResult List()
        {
            var model = new List<AuctionModel>
            {
                new AuctionModel { Id = 1, ProductName = "Cool Gadget", HighestBid = "$150.00", TotalBids = 12, EndDate = "2024-12-31 18:00" },
                new AuctionModel { Id = 2, ProductName = "Vintage Watch", HighestBid = "$850.00", TotalBids = 35, EndDate = "2024-12-25 12:00" },
                new AuctionModel { Id = 3, ProductName = "Signed Baseball", HighestBid = "$45.00", TotalBids = 8, EndDate = "2025-01-05 20:00" }
            };

            return View("~/Plugins/Auctions.Auction/Views/Admin/List.cshtml", model);
        }
    }
}
