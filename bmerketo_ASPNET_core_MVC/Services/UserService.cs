using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace bmerketo_ASPNET_core_MVC.Services;

public class UserService
{
    private readonly IdentityContext _identityContext;

    public UserService(IdentityContext identityContext)
    {
        _identityContext = identityContext;
    }

    public async Task<UserProfileEntity> GetUserProfileAsync(string userId)
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
        var roles = await _identityContext.Roles.ToListAsync();

        foreach (var user in users)
        {
            UserCardViewModel userCardViewModel = user;
            profiles.Add(userCardViewModel);
        }

        return profiles;
    }
}
