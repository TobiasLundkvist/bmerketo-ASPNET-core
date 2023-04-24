using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;
using System.Security.Claims;

namespace bmerketo_ASPNET_core_MVC.Services;

public class AuthorizationService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IdentityContext _identityContext;
    private readonly SeedService _seedService;

    public AuthorizationService(UserManager<IdentityUser> userManager, IdentityContext identityContext, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, SeedService seedService)
    {
        _userManager = userManager;
        _identityContext = identityContext;
        _signInManager = signInManager;
        _roleManager = roleManager;
        _seedService = seedService;
    }

    // Create User
    public async Task<bool> RegisterAsync (UserRegisterViewModel model)
    {
        try
        {
            await _seedService.SeedRoles();
            var roleName = "user";

            if (!await _userManager.Users.AnyAsync())
                roleName = "admin";

            IdentityUser identityUser = model;
            await _userManager.CreateAsync(identityUser, model.Password);

            await _userManager.AddToRoleAsync(identityUser, roleName);

            UserProfileEntity profile = model;
            profile.UserId = identityUser.Id;

            _identityContext.UserProfiles.Add(profile);
            await _identityContext.SaveChangesAsync();

            return true;
        }
        catch { return false; }  
    }

    // Check if email already exists
    public async Task<bool> Exists(Expression<Func<IdentityUser, bool>> expression)
    {
        return await _userManager.Users.AnyAsync(expression);
    }


    //Login
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
