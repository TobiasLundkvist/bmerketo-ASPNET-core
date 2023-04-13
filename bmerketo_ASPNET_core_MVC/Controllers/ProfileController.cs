using bmerketo_ASPNET_core_MVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class ProfileController : Controller
{

    private readonly AuthorizationService _authorizationService;

    public ProfileController(AuthorizationService authorizationService)
    {
        _authorizationService = authorizationService;
    }


    // Profile View
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }


    // Sign out
    [Authorize]
    public new async Task<IActionResult> SignOut()
    {
        if (await _authorizationService.LogOutAsync(User))
            return LocalRedirect("/");


        return RedirectToAction("Index");
    }
}
