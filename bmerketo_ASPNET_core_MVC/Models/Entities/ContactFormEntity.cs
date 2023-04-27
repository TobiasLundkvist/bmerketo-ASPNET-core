using bmerketo_ASPNET_core_MVC.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace bmerketo_ASPNET_core_MVC.Models.Entities;

public class ContactFormEntity
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;
    
    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? CompanyName { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Message { get; set; } = null!;


    public static implicit operator ContactFormViewModel(ContactFormEntity entity)
    {
        return new ContactFormViewModel
        {
            Name = entity.Name,
            Email = entity.Email,
            PhoneNumber = entity.PhoneNumber,
            CompanyName = entity.CompanyName,
            Message = entity.Message
        };
    }
}
