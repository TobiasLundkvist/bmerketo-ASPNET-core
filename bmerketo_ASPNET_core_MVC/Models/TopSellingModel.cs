using bmerketo_ASPNET_core_MVC.ViewModels;

namespace bmerketo_ASPNET_core_MVC.Models;

public class TopSellingModel
{
    public string Title { get; set; } = null!;
    public IEnumerable<ProductCardViewModel> TopSellingProducts { get; set; } = null!;
    public bool ArrowButtons { get; set; } = false;
}
