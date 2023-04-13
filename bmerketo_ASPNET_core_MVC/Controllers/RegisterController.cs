using bmerketo_ASPNET_core_MVC.Services;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class RegisterController : Controller
{
    private readonly AuthorizationService _authorizationService;

    public RegisterController(AuthorizationService authorizationService)
    {
        _authorizationService = authorizationService;
    }




    public IActionResult Index()
    {
        return View();
    }



    [HttpPost]
    public async Task<IActionResult> Index(UserRegisterViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            if (await _authorizationService.RegisterAsync(viewModel))
                return RedirectToAction("Index", "Home");

            ModelState.AddModelError("", "User with the same Email already exists");

        }

        return View(viewModel);
    }
}
