using bmerketo_ASPNET_core_MVC.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bmerketo_ASPNET_core_MVC.Contexts;

public class IdentityContext : IdentityDbContext
{
    public IdentityContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<UserProfileEntity> UserProfiles { get; set; }

}
