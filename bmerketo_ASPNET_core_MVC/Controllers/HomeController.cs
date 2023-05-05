using bmerketo_ASPNET_core_MVC.Models;
using bmerketo_ASPNET_core_MVC.Services;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        ViewData["Title"] = "Home";

        var viewModel = new HomeIndexViewModel
        {
            ShowcaseModel = new ShowcaseModel()
            {
                Ingress = "WELLCOME TO BMARKETO SHOP",
                Title = "Exclusive Chair gold Collection",
                LinkContent = "SHOP NOW",
                LinkUrl = "/Products",
                ImageUrl = "images/placeholders/625x647.svg"
            },

            BestCollectionModel = new BestCollectionModel()
            {
               Title = "Best Collection",
               Categories = new List<string> { "All", "Bag", "Dress", "Decoration", "Essentials", "Interior", "Laptops", "Mobile", "Beauty" },
               ProductCardItems = new List<ProductCardViewModel>
               {
                   new ProductCardViewModel { Title = "Apple watch series", Price = 30, ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Title = "Table Lamp", Price = 30, ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Title = "laptop thinkpad lenovo", Price = 30, ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Title = "Table Lamp", Price = 30, ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Title = "Gumshoes black fashion", Price = 80, OldPrice = 120, ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Title = "Woman white dress", Price = 30, ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Title = "Kettle water boiler", Price = 30, ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Title = "Congee cooking rice cooker", Price = 30, ImageUrl = "images/placeholders/270x295.svg" },
               },
               LoadMore = true
            },

            UpToSellModel = new UpToSellModel()
            {
                TitleRed = "UP TO SALE",
                Title = "50% OFF",
                Ingress = "Get the Best Price",
                Text = "Get the best daily offer et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren no sea taki",
                LinkText = "Discover More",
                LinkUrl = "",
                UpToSellProduct1 = new List<ProductCardViewModel> 
                {  
                    new ProductCardViewModel { Title = "TEST1 - scelerisque tempore", Price = 30, OldPrice = 50, ImageUrl = "images/placeholders/369x310.svg" },
                },

                UpToSellProduct2 = new List<ProductCardViewModel>
                {
                    new ProductCardViewModel { Title = "TEST2 - scelerisque tempore", Price = 30, OldPrice = 50, ImageUrl = "images/placeholders/369x310.svg" }
                }


            },

            TopSellingModel = new TopSellingModel()
            {
                Title = "Top selling products in this week",
                TopSellingProducts = new List<ProductCardViewModel>
                {
                    new ProductCardViewModel { Title = "Apple watch series", Price = 80, OldPrice = 120, ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Title = "Gumshoes black fashion", Price = 80, OldPrice = 120, ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Title = "Woman white dress", Price = 30, ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Title = "Kettle water boiler", Price = 30, ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Title = "Congee cooking rice cooker", Price = 30, ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Title = "Pizza tomato sauce kebab", Price = 30, ImageUrl = "images/placeholders/270x295.svg" },
                },
                ArrowButtons = true
            },

            CommentedProductsModel = new CommentedProductsModel()
            {
                CommentedProducts = new List<ProductCardViewModel>
                {
                    new ProductCardViewModel { Title = "Table lamp 1562 LTG modal", ImageUrl = "images/placeholders/370x295.svg", Comment = "Best dress for everyone ed totam velit risus viverra nobis donec recusandae perspiciatis incididuno", PostedBy = "POST BY: ADMIN", CommentQty = "COMMENTS 13", ShopNow = false },
                    new ProductCardViewModel { Title = "Table lamp 1562 LTG modal", ImageUrl = "images/placeholders/370x295.svg", Comment = "Best dress for everyone ed totam velit risus viverra nobis donec recusandae perspiciatis incididuno", PostedBy = "POST BY: ADMIN", CommentQty = "COMMENTS 13", ShopNow = false  },
                    new ProductCardViewModel { Title = "Table lamp 1562 LTG modal", ImageUrl = "images/placeholders/370x295.svg", Comment = "Best dress for everyone ed totam velit risus viverra nobis donec recusandae perspiciatis incididuno", PostedBy = "POST BY: ADMIN", CommentQty = "COMMENTS 13", ShopNow = false  },
                }
            }
        
        };
        return View(viewModel);
    }
}
