using bmerketo_ASPNET_core_MVC.Models;
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
                   new ProductCardViewModel { Id = "1", Title = "Apple watch series", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "2", Title = "Table Lamp", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "3", Title = "laptop thinkpad lenovo", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "4", Title = "Table Lamp", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "5", Title = "Gumshoes black fashion", Price = "$80.00", OldPrice = "$120.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "6", Title = "Woman white dress", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "7", Title = "Kettle water boiler", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "8", Title = "Congee cooking rice cooker", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" },
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
                    new ProductCardViewModel { Id = "9", Title = "TEST1 - scelerisque tempore", Price = "$30.00", OldPrice = "$50.00", ImageUrl = "images/placeholders/369x310.svg" },
                },

                UpToSellProduct2 = new List<ProductCardViewModel>
                {
                    new ProductCardViewModel { Id = "10", Title = "TEST2 - scelerisque tempore", Price = "$30.00", OldPrice = "$50.00", ImageUrl = "images/placeholders/369x310.svg" }
                }


            },

            TopSellingModel = new TopSellingModel()
            {
                Title = "Top selling products in this week",
                TopSellingProducts = new List<ProductCardViewModel>
                {
                    new ProductCardViewModel { Id = "11", Title = "Apple watch series", Price = "$80.00", OldPrice = "$120.00", ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Id = "12", Title = "Gumshoes black fashion", Price = "$80.00", OldPrice = "$120.00", ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Id = "13", Title = "Woman white dress", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Id = "14", Title = "Kettle water boiler", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Id = "15", Title = "Congee cooking rice cooker", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" },
                    new ProductCardViewModel { Id = "16", Title = "Pizza tomato sauce kebab", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" },
                },
                ArrowButtons = true
            },

            CommentedProductsModel = new CommentedProductsModel()
            {
                CommentedProducts = new List<ProductCardViewModel>
                {
                    new ProductCardViewModel { Id = "17", Title = "Table lamp 1562 LTG modal", ImageUrl = "images/placeholders/370x295.svg", Comment = "Best dress for everyone ed totam velit risus viverra nobis donec recusandae perspiciatis incididuno", PostedBy = "POST BY: ADMIN", CommentQty = "COMMENTS 13", ShopNow = false },
                    new ProductCardViewModel { Id = "18", Title = "Table lamp 1562 LTG modal", ImageUrl = "images/placeholders/370x295.svg", Comment = "Best dress for everyone ed totam velit risus viverra nobis donec recusandae perspiciatis incididuno", PostedBy = "POST BY: ADMIN", CommentQty = "COMMENTS 13", ShopNow = false  },
                    new ProductCardViewModel { Id = "19", Title = "Table lamp 1562 LTG modal", ImageUrl = "images/placeholders/370x295.svg", Comment = "Best dress for everyone ed totam velit risus viverra nobis donec recusandae perspiciatis incididuno", PostedBy = "POST BY: ADMIN", CommentQty = "COMMENTS 13", ShopNow = false  },
                }
            }
        
        };




        return View(viewModel);
    }
}
