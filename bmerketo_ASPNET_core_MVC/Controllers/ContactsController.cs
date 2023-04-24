using bmerketo_ASPNET_core_MVC.Models;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class ContactsController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Contact Us";

        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Index(ContactFormViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            ModelState.AddModelError("", "Something went wrong");
        }


        return View(viewModel);
    }
}
