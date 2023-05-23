using System.ComponentModel.DataAnnotations;

namespace bmerketo_ASPNET_core_MVC.ViewModels;

public class UserLoginViewModel
{
    [Required(ErrorMessage = "Email Address is required")]
    [Display(Name = "Email Address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Required(ErrorMessage = "Password is required")]
    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    public bool RememberMe { get; set; }
}
