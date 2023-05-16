using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.Services;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace bmerketo_ASPNET_core_MVC.Controllers;

public class ProfileController : Controller
{

    private readonly AuthorizationService _authorizationService;
    private readonly UserService _userService;

    public ProfileController(AuthorizationService authorizationService, UserService userService)
    {
        _authorizationService = authorizationService;
        _userService = userService;
    }


    // Profile View
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }

    [Authorize]
    [HttpGet]
    public async Task<ActionResult<UserCardViewModel>> Index(UserProfileEntity profileEntity)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var user = await _userService.GetUserProfileAsync(userId!);
        if(user != null)
            return View(user);
        else
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
