﻿using bmerketo_ASPNET_core_MVC.Models;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace bmerketo_ASPNET_core_MVC.ViewModels;

public class ProductsCreateFormViewModel
{
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



    [Display(Name = "Discounted Price")]
    public string DiscountPrice { get; set; } = null!;



    public static implicit operator ProductEntity(ProductsCreateFormViewModel productsCreateFormViewModel)
    {
        return new ProductEntity
        {
            ImageUrl = productsCreateFormViewModel.ImageUrl,
            ProductName = productsCreateFormViewModel.ProductName,
            Description = productsCreateFormViewModel.Description,
            Price = productsCreateFormViewModel.Price,
            DiscountPrice = productsCreateFormViewModel.DiscountPrice
        };
    }
}
