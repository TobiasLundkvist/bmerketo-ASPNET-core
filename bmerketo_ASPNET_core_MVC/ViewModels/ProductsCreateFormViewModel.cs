using bmerketo_ASPNET_core_MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace bmerketo_ASPNET_core_MVC.ViewModels;

public class ProductsCreateFormViewModel
{
    //public BreadcrumbModel BreadcrumbModel { get; set; } = null!;



    [Required(ErrorMessage = "Product Title is required")]
    [Display(Name = "Product Name")]
    public string ProductName { get; set; } = null!;



    [Required(ErrorMessage = "Product Image is required")]
    [Display(Name = "Product Image")]
    public string ImageUrl { get; set; } = null!;



    [Display(Name = "Product Description")]
    public string Description { get; set; } = null!;



    [Required(ErrorMessage = "Product Price is required")]
    [Display(Name = "Price")]
    public string Price { get; set; } = null!;

}
