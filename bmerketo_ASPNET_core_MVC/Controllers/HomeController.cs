using bmerketo_ASPNET_core_MVC.Models;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        ViewData["Title"] = "Home";

        //var showcase = new ShowcaseViewModel()
        //{
        //    Ingress = "WELCOME TO BMERKETO SHOP",
        //    Title = "Exclusive Chair gold Collection",
        //    LinkContent = "SHOP NOW",
        //    LinkUrl = "/Products",
        //    ImageUrl = "images/placeholders/625x647.svg"
        //};




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
               BestCollectionItems = new List<ProductCardViewModel>
               {
                   new ProductCardViewModel { Id = "1", Title = "Apple watch series", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "2", Title = "Table Lamp", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "3", Title = "laptop thinkpad lenovo", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "4", Title = "Table Lamp", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "5", Title = "Gumshoes black fashion", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "6", Title = "Woman white dress", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "7", Title = "Kettle water boiler", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" }, 
                   new ProductCardViewModel { Id = "8", Title = "Congee cooking rice cooker", Price = "$30.00", ImageUrl = "images/placeholders/270x295.svg" },
               }
            },

            UpToSellModel = new UpToSellModel()
            {
                TitleRed = "UP TO SALE",
                Title = "50% OFF",
                Ingress = "Get the Best Price",
                Text = "Get the best daily offer et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren no sea taki",
                LinkText = "Discover More",
                LinkUrl = ""

            }
        };




        return View(viewModel);
    }
}
