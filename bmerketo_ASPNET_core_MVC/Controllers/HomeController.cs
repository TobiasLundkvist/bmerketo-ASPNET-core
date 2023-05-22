using bmerketo_ASPNET_core_MVC.Models;
using bmerketo_ASPNET_core_MVC.Services;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService;
    }

    public async Task<IActionResult> Index()
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
                ProductCardItems = await _productService.GetAllByTagsAsync(2),
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
                    new ProductCardViewModel { Title = "TEST1 - scelerisque tempore", Price = 30, OldPrice = 50, ImageUrl = "https://s7template.com/tf/bmarketo/assets/img/discount/1.png" },
                },

                UpToSellProduct2 = new List<ProductCardViewModel>
                {
                    new ProductCardViewModel { Title = "TEST2 - scelerisque tempore", Price = 30, OldPrice = 50, ImageUrl = "https://s7template.com/tf/bmarketo/assets/img/discount/2.png" }
                }


            },

            TopSellingModel = new TopSellingModel()
            {
                Title = "Top selling products in this week",
                TopSellingProducts = await _productService.GetAllByTagsAsync(3),
                ArrowButtons = true
            },

            CommentedProductsModel = new CommentedProductsModel()
            {
                CommentedProducts = new List<ProductCardViewModel>
                {
                    new ProductCardViewModel { Title = "Table lamp 1562 LTG modal", ImageUrl = "https://s7template.com/tf/bmarketo/assets/img/blog/1.png", Comment = "Best dress for everyone ed totam velit risus viverra nobis donec recusandae perspiciatis incididuno", PostedBy = "POST BY: ADMIN", CommentQty = "COMMENTS 13", ShopNow = false },
                    new ProductCardViewModel { Title = "Exclusive Chair 1562 LTG", ImageUrl = "https://s7template.com/tf/bmarketo/assets/img/blog/2.png", Comment = "Best dress for everyone ed totam velit risus viverra nobis donec recusandae perspiciatis incididuno", PostedBy = "POST BY: ADMIN", CommentQty = "COMMENTS 13", ShopNow = false  },
                    new ProductCardViewModel { Title = "Vase glass 1562 LTG modal", ImageUrl = "https://s7template.com/tf/bmarketo/assets/img/blog/3.png", Comment = "Best dress for everyone ed totam velit risus viverra nobis donec recusandae perspiciatis incididuno", PostedBy = "POST BY: ADMIN", CommentQty = "COMMENTS 13", ShopNow = false  },
                }
            }
        
        };
        return View(viewModel);
    }
}
