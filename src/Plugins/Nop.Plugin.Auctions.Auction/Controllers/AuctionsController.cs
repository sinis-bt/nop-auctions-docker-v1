using Microsoft.AspNetCore.Mvc;
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
    }
}
