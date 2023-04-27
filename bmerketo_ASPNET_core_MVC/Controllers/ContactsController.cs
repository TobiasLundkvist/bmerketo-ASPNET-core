using bmerketo_ASPNET_core_MVC.Models;
using bmerketo_ASPNET_core_MVC.Services;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class ContactsController : Controller
{
    private readonly ContactMessageService _contactMessageService;

    public ContactsController(ContactMessageService contactMessageService)
    {
        _contactMessageService = contactMessageService;
    }

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
            if (await _contactMessageService.CreateAsync(viewModel))
            {
                TempData["AlertMessage"] = "Success! We have got your message and will come back to you as fast as possible.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Something went wrong");
        }


        return View(viewModel);
    }
}
