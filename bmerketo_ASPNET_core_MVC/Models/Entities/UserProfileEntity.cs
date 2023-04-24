using bmerketo_ASPNET_core_MVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bmerketo_ASPNET_core_MVC.Models.Entities;

public class UserProfileEntity
{
    [Key, ForeignKey(nameof(User))]
    public string UserId { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set;} = null!;
    public string? StreetName { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }


    public IdentityUser User { get; set; } = null!;



    public static implicit operator UserCardViewModel(UserProfileEntity userProfileEntity)
    {
        return new UserCardViewModel
        {
            UserId = userProfileEntity.UserId,
            FirstName = userProfileEntity.FirstName,
            LastName = userProfileEntity.LastName,
            StreetName = userProfileEntity.StreetName,
            PostalCode = userProfileEntity.PostalCode,
            City = userProfileEntity.City
        };
    }
}
