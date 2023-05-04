namespace bmerketo_ASPNET_core_MVC.ViewModels;

public class ProductCardViewModel
{
    public string Id { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public decimal? Price { get; set; } = null!;
    public decimal? OldPrice { get; set; } = null!;
    public string? Comment { get; set; } = null!;
    public string? PostedBy { get; set; } = null!;
    public string? CommentQty { get; set; } = null!;
    public bool? ShopNow { get; set; } = true;
}
