using Microsoft.EntityFrameworkCore;

namespace bmerketo_ASPNET_core_MVC.Models.Entities
{

    [PrimaryKey(nameof(ProductNumber), nameof(TagId))]
    public class ProductTagEntity
    {
        public string ProductNumber { get; set; } = null!;
        public ProductEntity Product { get; set; } = null!;

        public int TagId { get; set; }
        public TagEntity Tag { get; set; } = null!;
    }
}
