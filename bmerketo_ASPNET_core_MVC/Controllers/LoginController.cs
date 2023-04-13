using bmerketo_ASPNET_core_MVC.Services;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmerketo_ASPNET_core_MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly AuthorizationService _authorizationService;

        public LoginController(AuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }



        public IActionResult Index()
        {
            return View();
        }



        // For login
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _authorizationService.LoginAsync(viewModel))
                    return RedirectToAction("Index", "Profile");

                ModelState.AddModelError("", "Incorrect email or password");

            }

            return View(viewModel);
        }
    }
}
