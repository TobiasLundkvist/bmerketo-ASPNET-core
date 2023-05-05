using bmerketo_ASPNET_core_MVC.Models.Entities;

namespace bmerketo_ASPNET_core_MVC.ViewModels;

public class ProductCardViewModel
{
    public string Id { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public decimal? OldPrice { get; set; } = null!;
    public string? Comment { get; set; } = null!;
    public string? PostedBy { get; set; } = null!;
    public string? CommentQty { get; set; } = null!;
    public bool? ShopNow { get; set; } = true;

    public int TagId { get; set; }
    public string TagName { get; set; } = null!;



    //public static implicit operator TagEntity(ProductCardViewModel model)
    //{
    //    return new TagEntity
    //    {
    //        Id = model.TagId,
    //        TagName = model.TagName,
    //    };
    //}

    //public static implicit operator ProductEntity(ProductCardViewModel model)
    //{
    //    return new ProductEntity
    //    {
    //        ProductNumber = model.Id,
    //        ProductName = model.Title,
    //        Description = model.Description,
    //        ImageUrl = model.ImageUrl,
    //        Price = model.Price,
    //    };
    //}

}
