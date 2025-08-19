using Nop.Core;

namespace Nop.Plugin.Auctions.Auction.Domain
{
    public class Bid : BaseEntity
    {
        public int AuctionId { get; set; }
        public int CustomerId { get; set; }
        public decimal BidAmount { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
