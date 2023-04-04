using bmerketo_ASPNET_core_MVC.Models;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class ContactsController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Contact Us";

        var contactViewModel = new ContactsIndexViewModel
        {
            BreadcrumbModel = new BreadcrumbModel()
            {
                Title = "CONTACT",
                SubTitleOne = "HOME",
                SubTitleTwo = "CONTACT",
            }
        };



        return View(contactViewModel);
    }
}
