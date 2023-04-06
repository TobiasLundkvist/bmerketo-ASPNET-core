using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace bmerketo_ASPNET_core_MVC.Services;

public class ProductService
{
    private readonly DataContext _context;

    public ProductService(DataContext context)
    {
        _context = context;
    }


    public async Task<bool> CreateAsync(ProductsCreateFormViewModel productsCreateFormViewModel)
    {
        try
        {
            ProductEntity productEntity = productsCreateFormViewModel;

            _context.Products.Add(productEntity);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }


    public async Task<IEnumerable<ProductCardViewModel>> GetAllAsync()
    {
        var products = new List<ProductCardViewModel>();
        var items  = await _context.Products.ToListAsync();

        foreach (var item in items)
        {
            ProductCardViewModel productCardViewModel = item;
            products.Add(productCardViewModel);
        }
        return products;
    }
}
