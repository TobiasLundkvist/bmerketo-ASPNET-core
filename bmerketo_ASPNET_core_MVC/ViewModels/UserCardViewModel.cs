namespace bmerketo_ASPNET_core_MVC.ViewModels;

public class UserCardViewModel
{
    public string UserId { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? StreetName { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }
    public string? PhoneNumber { get; set; }
    public string Role { get; set; } = null!;
}
