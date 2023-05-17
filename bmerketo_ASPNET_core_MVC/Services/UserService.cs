using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bmerketo_ASPNET_core_MVC.Services;

public class UserService
{
    private readonly IdentityContext _identityContext;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public UserService(IdentityContext identityContext, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _identityContext = identityContext;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<UserCardViewModel> GetUserProfileAsync(string userId)
    {
        var userProfileEntity = await _identityContext.UserProfiles.Include(x => x.User).FirstOrDefaultAsync(x => x.UserId == userId);
        return userProfileEntity!;
    }

    public async Task<IEnumerable<UserCardViewModel>> GetAllUserProfileAsync()
    {
        var profiles = new List<UserCardViewModel>();
        var users = await _identityContext.UserProfiles
            .Include(x => x.User)
            .ToListAsync();

        foreach (var user in users)
        {
            UserCardViewModel userCardViewModel = user;
            userCardViewModel.Roles = await _userManager.GetRolesAsync(user.User);
            profiles.Add(userCardViewModel);
        }

        return profiles;
    }

    public async Task<IdentityUser> UpdateRole(string userId)
    {
        var newRole = "admin";
        

        var user = await _userManager.FindByIdAsync(userId);
        var currentRole = await _userManager.GetRolesAsync(user!);
        await _userManager.RemoveFromRolesAsync(user!, currentRole);
        await _userManager.AddToRoleAsync(user!, newRole);

        return user!;
    }
}
