using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models.Entities;
using bmerketo_ASPNET_core_MVC.ViewModels;

namespace bmerketo_ASPNET_core_MVC.Services;

public class ContactMessageService
{
    private readonly DataContext _context;

    public ContactMessageService(DataContext context)
    {
        _context = context;
    }


    public async Task<bool> CreateAsync(ContactFormViewModel contactFormViewModel)
    {
        try
        {
            ContactFormEntity contactFormEntity = contactFormViewModel;

            _context.ContactFormMessages.Add(contactFormEntity);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
