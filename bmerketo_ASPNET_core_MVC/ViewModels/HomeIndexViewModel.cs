using bmerketo_ASPNET_core_MVC.Models;

namespace bmerketo_ASPNET_core_MVC.ViewModels
{
    public class HomeIndexViewModel
    {
        public ShowcaseModel ShowcaseModel { get; set; } = null!;
        public BestCollectionModel BestCollectionModel { get; set; } = null!;
        public UpToSellModel UpToSellModel { get; set; } = null!;
    }
}
