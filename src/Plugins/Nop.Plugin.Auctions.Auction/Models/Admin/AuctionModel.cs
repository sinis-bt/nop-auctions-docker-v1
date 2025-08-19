using Nop.Web.Framework.Models;

namespace Nop.Plugin.Auctions.Auction.Models.Admin
{
    public record AuctionModel : BaseNopEntityModel
    {
        public string ProductName { get; set; }
        public string HighestBid { get; set; }
        public int TotalBids { get; set; }
        public string EndDate { get; set; }
    }
}
