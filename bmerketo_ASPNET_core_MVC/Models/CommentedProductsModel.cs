using bmerketo_ASPNET_core_MVC.ViewModels;

namespace bmerketo_ASPNET_core_MVC.Models;

public class CommentedProductsModel
{
    public IEnumerable<ProductCardViewModel> CommentedProducts { get; set; } = null!;
}
