using bmerketo_ASPNET_core_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace bmerketo_ASPNET_core_MVC.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }


    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<ProductTagEntity> ProductTags { get; set; }
    public DbSet<ContactFormEntity> ContactFormMessages { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<ProductCategoryEntity>().HasData(
    //        new {Id = 1, CategoryName = "new"},
    //        new {Id = 2, CategoryName = "featured"},
    //        new {Id = 3, CategoryName = "popular"}
    //    );
    //}
}
