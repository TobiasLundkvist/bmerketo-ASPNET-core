using bmerketo_ASPNET_core_MVC.ViewModels;

namespace bmerketo_ASPNET_core_MVC.Models;

public class UpToSellModel
{
    public string? TitleRed { get; set; } = null!;
    public string? Title { get; set; } = null!;
    public string? Ingress { get; set; } = null!;
    public string? Text { get; set; } = null!;
    public string? LinkText { get; set; } = null!;
    public string? LinkUrl { get; set; } = null!;

    public IEnumerable<ProductCardViewModel> UpToSellProduct1 { get; set; } = null!;
    public IEnumerable<ProductCardViewModel> UpToSellProduct2 { get; set; } = null!;

}
