using bmerketo_ASPNET_core_MVC.Models.Entities;
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
    [StringLength(100, MinimumLength = 3)]
    public string Message { get; set; } = null!;
    
    
    public bool RememberMe { get; set; }


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
