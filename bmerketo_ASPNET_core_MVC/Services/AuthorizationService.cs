using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace bmerketo_ASPNET_core_MVC.Services;

public class AuthorizationService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    private readonly IdentityContext _identityContext;

    public AuthorizationService(UserManager<IdentityUser> userManager, IdentityContext identityContext, SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _identityContext = identityContext;
        _signInManager = signInManager;
    }

    // Create User
    public async Task<bool> RegisterAsync (UserRegisterViewModel model)
    {
        try
        {
            IdentityUser identityUser = model;
            await _userManager.CreateAsync(identityUser, model.Password);

            UserProfileEntity profile = model;
            profile.UserId = identityUser.Id;

            _identityContext.UserProfiles.Add(profile);
            await _identityContext.SaveChangesAsync();

            return true;
        }
        catch { return false; }  
    }


    public async Task<bool> LoginAsync(UserLoginViewModel model)
    {
        try
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            return result.Succeeded;
        }
        catch { return false; }
    }


    // Log out, control that user is signed in or signed out also
    public async Task<bool> LogOutAsync(ClaimsPrincipal user)
    {
        await _signInManager.SignOutAsync();
        return _signInManager.IsSignedIn(user);
    }
}
