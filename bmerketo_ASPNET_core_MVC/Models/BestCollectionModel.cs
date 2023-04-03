using bmerketo_ASPNET_core_MVC.ViewModels;

namespace bmerketo_ASPNET_core_MVC.Models;

public class BestCollectionModel
{
    public string? Title { get; set; }
    public IEnumerable<string> Categories { get; set; } = null!;
    public IEnumerable<ProductCardViewModel> BestCollectionItems { get; set; } = null!;
    public bool LoadMore { get; set; } = false;
}
