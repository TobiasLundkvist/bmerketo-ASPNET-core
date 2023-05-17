using bmerketo_ASPNET_core_MVC.Services;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers;


[Authorize(Roles = "admin")]
public class AdminController : Controller
{
    private readonly UserService _userService;

    public AdminController(UserService userService)
    {
        _userService = userService;
    }




    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index([FromQuery(Name = "itemid")] string userId)
    {
        
        //var getUser = await _userService.GetUserProfileAsync();

        var user = await _userService.UpdateRole(userId);

        return View(user);

    }
}
