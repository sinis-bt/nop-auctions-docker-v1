using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Auctions.Auction.Models.Public;
using Nop.Web.Framework.Controllers;
using Nop.Web.Models.Catalog;
using Nop.Web.Models.Media;
using System.Collections.Generic;

namespace Nop.Plugin.Auctions.Auction.Controllers
{
    public class AuctionsController : BasePluginController
    {
        public IActionResult Index()
        {
            var model = new List<ProductOverviewModel>
            {
                new ProductOverviewModel
                {
                    Id = 1,
                    Name = "Cool Gadget",
                    ShortDescription = "A really cool gadget that does amazing things.",
                    SeName = "cool-gadget", // Used for URL generation
                    ProductPrice = new ProductPriceModel
                    {
                        Price = "Current Bid: $150.00"
                    },
                    PictureModels = new List<PictureModel>
                    {
                        new PictureModel
                        {
                            ImageUrl = "/images/samples/product_macbook_1.jpeg",
                            Title = "Show details for Cool Gadget",
                            AlternateText = "Image of Cool Gadget"
                        }
                    }
                },
                new ProductOverviewModel
                {
                    Id = 2,
                    Name = "Vintage Watch",
                    ShortDescription = "A stylish vintage watch from the 1960s.",
                    SeName = "vintage-watch", // Used for URL generation
                    ProductPrice = new ProductPriceModel
                    {
                        Price = "Current Bid: $850.00"
                    },
                    PictureModels = new List<PictureModel>
                    {
                        new PictureModel
                        {
                            ImageUrl = "/images/samples/product_Lumia1020.jpeg",
                            Title = "Show details for Vintage Watch",
                            AlternateText = "Image of Vintage Watch"
                        }
                    }
                },
                new ProductOverviewModel
                {
                    Id = 3,
                    Name = "Signed Baseball",
                    ShortDescription = "A baseball signed by a famous player.",
                    SeName = "signed-baseball", // Used for URL generation
                    ProductPrice = new ProductPriceModel
                    {
                        Price = "Current Bid: $45.00"
                    },
                    PictureModels = new List<PictureModel>
                    {
                        new PictureModel
                        {
                            ImageUrl = "/images/samples/product_adidas.jpg",
                            Title = "Show details for Signed Baseball",
                            AlternateText = "Image of Signed Baseball"
                        }
                    }
                }
            };

            return View("~/Plugins/Auctions.Auction/Views/Public/Index.cshtml", model);
        }

        public IActionResult AuctionDetails(int id)
        {
            // In a real application, you would fetch the auction details from the database based on the id.
            // For this POC, we'll just create a hard-coded model based on the id.
            var auctions = new List<AuctionDetailsModel>
            {
                new AuctionDetailsModel
                {
                    Id = 1,
                    Name = "Cool Gadget",
                    ShortDescription = "A really cool gadget that does amazing things.",
                    FullDescription = "This is the full description of the cool gadget. It's made from the finest materials and has a lot of features that you will love. It's perfect for everyday use and will make your life much easier. Don't miss this opportunity to own the best gadget ever!",
                    CurrentBid = "$150.00",
                    TimeLeft = "3 days, 4 hours",
                    NumberOfBids = 12,
                    Bids = new List<BidModel>
                    {
                        new BidModel { CustomerName = "John D.", BidAmount = "$150.00", Timestamp = "2024-08-18 14:30" },
                        new BidModel { CustomerName = "Jane S.", BidAmount = "$140.00", Timestamp = "2024-08-18 12:15" },
                        new BidModel { CustomerName = "Peter J.", BidAmount = "$130.00", Timestamp = "2024-08-17 21:00" }
                    },
                    PictureModels = new List<PictureModel> { new PictureModel { ImageUrl = "/images/samples/product_macbook_1.jpeg", Title = "Show details for Cool Gadget", AlternateText = "Image of Cool Gadget" } }
                },
                new AuctionDetailsModel
                {
                    Id = 2,
                    Name = "Vintage Watch",
                    ShortDescription = "A stylish vintage watch from the 1960s.",
                    FullDescription = "A beautiful vintage watch from a bygone era. This watch is a collector's item and is in excellent condition. It has been recently serviced and keeps perfect time.",
                    CurrentBid = "$850.00",
                    TimeLeft = "1 day, 2 hours",
                    NumberOfBids = 35,
                    Bids = new List<BidModel>
                    {
                        new BidModel { CustomerName = "Alice B.", BidAmount = "$850.00", Timestamp = "2024-08-19 10:00" },
                        new BidModel { CustomerName = "Bob C.", BidAmount = "$825.00", Timestamp = "2024-08-19 09:45" },
                        new BidModel { CustomerName = "Charlie E.", BidAmount = "$800.00", Timestamp = "2024-08-18 22:00" }
                    },
                    PictureModels = new List<PictureModel> { new PictureModel { ImageUrl = "/images/samples/product_Lumia1020.jpeg", Title = "Show details for Vintage Watch", AlternateText = "Image of Vintage Watch" } }
                },
                new AuctionDetailsModel
                {
                    Id = 3,
                    Name = "Signed Baseball",
                    ShortDescription = "A baseball signed by a famous player.",
                    FullDescription = "This baseball was signed by the legendary player after the championship game. It comes with a certificate of authenticity. A must-have for any serious collector.",
                    CurrentBid = "$45.00",
                    TimeLeft = "5 days, 1 hour",
                    NumberOfBids = 8,
                    Bids = new List<BidModel>
                    {
                        new BidModel { CustomerName = "Eve F.", BidAmount = "$45.00", Timestamp = "2024-08-15 11:00" },
                        new BidModel { CustomerName = "Frank G.", BidAmount = "$40.00", Timestamp = "2024-08-15 10:30" }
                    },
                    PictureModels = new List<PictureModel> { new PictureModel { ImageUrl = "/images/samples/product_adidas.jpg", Title = "Show details for Signed Baseball", AlternateText = "Image of Signed Baseball" } }
                }
            };

            var model = auctions.FirstOrDefault(a => a.Id == id) ?? auctions.First();

            return View("~/Plugins/Auctions.Auction/Views/Public/AuctionDetails.cshtml", model);
        }
    }
}
