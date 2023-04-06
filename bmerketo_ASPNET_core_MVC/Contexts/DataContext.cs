using bmerketo_ASPNET_core_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace bmerketo_ASPNET_core_MVC.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }


    public DbSet<ProductEntity> Products { get; set; }
}
