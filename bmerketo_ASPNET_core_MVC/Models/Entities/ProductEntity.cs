using bmerketo_ASPNET_core_MVC.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace bmerketo_ASPNET_core_MVC.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        [Required]
        public Guid ProductNumber { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public string ProductName { get; set; } = null!;

        [StringLength(100)]
        public string? Description { get; set; }

        [Required]
        public string Price { get; set; } = null!;


        public string? DiscountPrice { get; set; }


        public static implicit operator ProductCardViewModel (ProductEntity productEntity)
        {
            return new ProductCardViewModel
            {

                Id = productEntity.ProductNumber,
                ImageUrl = productEntity.ImageUrl,
                Title = productEntity.ProductName,
                Description = productEntity.Description,
                Price = productEntity.Price,
                OldPrice = productEntity.DiscountPrice,

            };
        }

    }
}
