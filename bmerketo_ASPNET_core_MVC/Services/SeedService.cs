using Microsoft.AspNetCore.Identity;

namespace bmerketo_ASPNET_core_MVC.Services;

public class SeedService
{
    private readonly RoleManager<IdentityRole> _roleManager;

    public SeedService(RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
    }


    // Create roles in AspNetRoles table
    public async Task SeedRoles()
    {
        if (!await _roleManager.RoleExistsAsync("admin"))
            await _roleManager.CreateAsync(new IdentityRole("admin"));

        if (!await _roleManager.RoleExistsAsync("user"))
            await _roleManager.CreateAsync(new IdentityRole("user"));
    }
}
