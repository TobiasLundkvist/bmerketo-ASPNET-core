using System.ComponentModel.DataAnnotations;

namespace bmerketo_ASPNET_core_MVC.ViewModels;

public class ContactFormViewModel
{
    [Required(ErrorMessage = "You need to enter your name")]
    [Display(Name = "Your Name")]
    public string Name { get; set; } = null!;


    [Required(ErrorMessage = "You need to enter an E-mail")]
    [Display(Name = "E-mail")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Phone Number")]
    public string? PhoneNumber { get; set; }
    
    
    [Display(Name = "Company name")]
    public string? CompanyName { get; set; }

    
    [Required(ErrorMessage = "You need to enter a message for us")]
    [Display(Name = "Message")]
    public string Message { get; set; } = null!;
    
    
    public bool RememberMe { get; set; }
}
