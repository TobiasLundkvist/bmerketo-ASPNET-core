using bmerketo_ASPNET_core_MVC.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "money")]
        public decimal Price { get; set; }



        public static implicit operator ProductCardViewModel (ProductEntity productEntity)
        {
            return new ProductCardViewModel
            {

                Id = productEntity.ProductNumber,
                ImageUrl = productEntity.ImageUrl,
                Title = productEntity.ProductName,
                Description = productEntity.Description,
                Price = productEntity.Price,

            };
        }

    }
}
