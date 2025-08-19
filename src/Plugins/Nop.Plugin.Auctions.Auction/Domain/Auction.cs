using Nop.Core;

namespace Nop.Plugin.Auctions.Auction.Domain
{
    public class Auction : BaseEntity
    {
        public int ProductId { get; set; }
        public decimal StartPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
