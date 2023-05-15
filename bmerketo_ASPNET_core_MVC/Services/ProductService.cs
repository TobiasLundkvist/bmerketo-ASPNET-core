using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.Repositories;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace bmerketo_ASPNET_core_MVC.Services;

public class ProductService
{
    private readonly DataContext _context;
    private readonly ProductTagRepository _productTagRepo;

    public ProductService(DataContext context, ProductTagRepository productTagRepo)
    {
        _context = context;
        _productTagRepo = productTagRepo;
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

    public async Task<ProductCardViewModel> GetAsync(string id)
    {
        var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductNumber == id);
        if (product != null)
        {
            return product;
        }
        else
            return null!;
    }

    public async Task<IEnumerable<ProductCardViewModel>> GetAllByTagsAsync(int tagId)
    {
        var products = new List<ProductCardViewModel>();
        var items = await _context.Products
            .Include(x => x.ProductTags)
            .ToListAsync();

        var tag = _context.ProductTags.Include(x => x.Tag).ThenInclude(x => x.Id).ToListAsync();

        foreach (var item in items)
        {
            ProductCardViewModel productCardViewModel = item;
            if(productCardViewModel != null)
            {
                if(productCardViewModel.TagIds != null && productCardViewModel.TagIds.Contains(tagId))
                {
                    products.Add(productCardViewModel);
                }
            }
        }
        return products;
    }


    public async Task<ProductCardViewModel> GetLastByTagAsync(int tagId)
    {
        var products = new ProductCardViewModel();
        var items = await _context.Products
            .Include(x => x.ProductTags)
            .ToListAsync();

        var tag = _context.ProductTags.Include(x => x.Tag).ThenInclude(x => x.Id).ToListAsync();

        ProductCardViewModel productCardViewModel = new ProductCardViewModel();
        if (productCardViewModel != null)
        {
            if (productCardViewModel.TagIds != null && productCardViewModel.TagIds.Contains(tagId))
            {
                return products;
            }
        }
        return products;
    }
}
