using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.Services;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class ProductsController : Controller
{
    private readonly ProductService _productService;
    private readonly TagService _tagService;

    public ProductsController(ProductService productService, TagService tagService)
    {
        _productService = productService;
        _tagService = tagService;
    }


    //All Products listed
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






    //Create Products
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> Create()
    {
        ViewData["Title"] = "Create Product";

        ViewBag.Tags = await _tagService.GetTagsAsync();

        return View();
    }

    [Authorize(Roles = "admin")]
    [HttpPost]
    public async Task<IActionResult> Create(ProductsCreateFormViewModel productsCreateFormViewModel, string[] tags)
    {
        if (ModelState.IsValid)
        {
            if (await _productService.CreateAsync(productsCreateFormViewModel))
            {
                await _tagService.AddProductTagsAsync(productsCreateFormViewModel, tags);
                return RedirectToAction("Index", "Products");
            }

            ModelState.AddModelError("", "Something went wrong");
        }

        ViewBag.Tags = await _tagService.GetTagsAsync(tags);
        return View(productsCreateFormViewModel);
    }






    public IActionResult DetailedProduct()
    {
        ViewData["Title"] = "Product";
        return View();
    }


    // Show one product
    [HttpGet]
    public async Task<ActionResult<ProductCardViewModel>> DetailedProduct(string Id)
    {
        ViewData["Title"] = "Product";
        var product = await _productService.GetAsync(Id);
        if (product != null)
            return View(product);
        else
            return null!;
    }




    public IActionResult Search()
    {
        ViewData["Title"] = "Search for products";
        return View();
    }
}
