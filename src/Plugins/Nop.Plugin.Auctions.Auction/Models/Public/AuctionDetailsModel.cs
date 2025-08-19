using Nop.Web.Models.Catalog;
using System.Collections.Generic;

namespace Nop.Plugin.Auctions.Auction.Models.Public
{
    public record AuctionDetailsModel : ProductDetailsModel
    {
        public string CurrentBid { get; set; }
        public string TimeLeft { get; set; }
        public int NumberOfBids { get; set; }
        public List<BidModel> Bids { get; set; } = new List<BidModel>();
    }

    public record BidModel
    {
        public string CustomerName { get; set; }
        public string BidAmount { get; set; }
        public string Timestamp { get; set; }
    }
}
