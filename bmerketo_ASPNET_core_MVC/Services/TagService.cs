using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.Repositories;
using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace bmerketo_ASPNET_core_MVC.Services;

public class TagService
{
    private readonly TagRepository _tagRepo;
    private readonly ProductTagRepository _productTagRepository;

    public TagService(TagRepository tagRepo, ProductTagRepository productTagRepository)
    {
        _tagRepo = tagRepo;
        _productTagRepository = productTagRepository;
    }

    public async Task<List<SelectListItem>> GetTagsAsync()
    {
        var tags = new List<SelectListItem>();

        foreach (var tag in await _tagRepo.GetAllAsync())
        {
            tags.Add(new SelectListItem
            {
                Value = tag.Id.ToString(),
                Text = tag.TagName
            });
        }

        return tags;
    }

    public async Task<List<SelectListItem>> GetTagsAsync(string[] selectedTags)
    {
        var tags = new List<SelectListItem>();

        foreach (var tag in await _tagRepo.GetAllAsync())
        {
            tags.Add(new SelectListItem
            {
                Value = tag.Id.ToString(),
                Text = tag.TagName,
                Selected = selectedTags.Contains(tag.Id.ToString())
            });
        }

        return tags;
    }

    public async Task AddProductTagsAsync(ProductsCreateFormViewModel productsCreateFormViewModel, string[] tags)
    {
        foreach(var tag in tags)
        {
            await _productTagRepository.AddAsync(new ProductTagEntity
            {
                ProductNumber = productsCreateFormViewModel.ProductNumber,
                TagId = int.Parse(tag)
            });
        }
    }

}
