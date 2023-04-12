using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.Services;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class ProductsController : Controller
{
    private readonly ProductService _productService;

    public ProductsController(ProductService productService)
    {
        _productService = productService;
    }



    public IActionResult Index()
    {
        ViewData["Title"] = "Products";

        var viewModel = new ProductsIndexViewModel
        {
            BreadcrumbModel = new BreadcrumbModel()
            {
                Title = "PRODUCTS",
                SubTitleOne = "HOME",
                SubTitleTwo = "CONTACT"
            }
        };


        return View(viewModel);
    }





    public IActionResult Create()
    {
        ViewData["Title"] = "Create Product";
        

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductsCreateFormViewModel productsCreateFormViewModel)
    {
        if (ModelState.IsValid)
        {
            if (await _productService.CreateAsync(productsCreateFormViewModel))
                return RedirectToAction("Index", "Products");

            ModelState.AddModelError("", "Something went wrong");
        }

        return View(productsCreateFormViewModel);
    }






    public IActionResult Search()
    {
        ViewData["Title"] = "Search for products";
        return View();
    }
}
