using bmerketo_ASPNET_core_MVC.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace bmerketo_ASPNET_core_MVC.ViewModels;

public class ContactFormViewModel
{
    [Required(ErrorMessage = "You need to enter your name")]
    [Display(Name = "Your Name")]
    [RegularExpression(@"^[A-Z][a-z]*\s[A-Z][a-z]*$", ErrorMessage = "Please enter your Firstname and Lastname with capital letters")]
    public string Name { get; set; } = null!;



    [Required(ErrorMessage = "You need to enter an E-mail")]
    [Display(Name = "E-mail")]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid E-mailaddress")]
    public string Email { get; set; } = null!;



    [Display(Name = "Phone Number")]
    public string? PhoneNumber { get; set; }
    
    

    [Display(Name = "Company name")]
    public string? CompanyName { get; set; }


    
    [Required(ErrorMessage = "You need to enter a message for us")]
    [Display(Name = "Message")]
    [StringLength(100, MinimumLength = 3)]
    public string Message { get; set; } = null!;
    
    
    public bool RememberMe { get; set; }


    // Gör om till en ContactFormEntity baserat på ContactFormViewModel
    public static implicit operator ContactFormEntity(ContactFormViewModel model)
    {
        return new ContactFormEntity
        {
            Name = model.Name,
            Email = model.Email,
            PhoneNumber = model.PhoneNumber,
            CompanyName = model.CompanyName,
            Message = model.Message
        };
    }

}
