using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Auctions.Auction.Infrastructure
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            // Public page
            endpointRouteBuilder.MapControllerRoute(
                "Plugin.Auctions.Auction.Index",
                "Auctions/Index",
                new { controller = "Auctions", action = "Index" });

            // Auction details page
            endpointRouteBuilder.MapControllerRoute(
                "Plugin.Auctions.Auction.AuctionDetails",
                "auction/{id}/{SeName}",
                new { controller = "Auctions", action = "AuctionDetails" });

            // Admin page
            endpointRouteBuilder.MapControllerRoute(
                "Admin.Plugin.Auctions.Auction.List",
                "Admin/AuctionsAdmin/List",
                new { controller = "AuctionsAdmin", action = "List", area = "Admin" });
        }

        public int Priority => 0;
    }
}
