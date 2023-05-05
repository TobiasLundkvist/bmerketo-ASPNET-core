using bmerketo_ASPNET_core_MVC.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace bmerketo_ASPNET_core_MVC.ViewModels;

public class UserRegisterViewModel
{
    [Required(ErrorMessage = "First Name is required")]
    [Display(Name = "First Name")]
    [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Start with captial letter eg. Firstname")]
    public string FirstName { get; set; } = null!;

    
    [Required(ErrorMessage = "Last Name is required")]
    [Display(Name = "Last Name")]
    [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Start with captial letter eg. Lastname")]
    public string LastName { get; set; } = null!;

    
    [Required(ErrorMessage = "Email Address is required")]
    [Display(Name = "Email Address")]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid E-mailaddress, eg. name@domain.com")]
    public string Email { get; set; } = null!;


    [Required(ErrorMessage = "Password is required")]
    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Compare(nameof(Password))]
    [Required(ErrorMessage = "Confirming Password is required")]
    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "Phone Number")]
    public string? PhoneNumber { get; set; }
    
    
    [Display(Name = "Street Name")]
    public string? StreetName { get; set; }
    
   
    [Display(Name = "Postal Code")]
    public string? PostalCode { get; set; }

    
    [Display(Name = "City")]
    public string? City { get; set; }




    public static implicit operator IdentityUser(UserRegisterViewModel model)
    {
        return new IdentityUser
        {
            UserName = model.Email,
            Email = model.Email,
            PhoneNumber = model.PhoneNumber
        };
    }

    public static implicit operator UserProfileEntity(UserRegisterViewModel model)
    {
        return new UserProfileEntity
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            StreetName = model.StreetName,
            PostalCode = model.PostalCode,
            City = model.City
        };
    }
}
