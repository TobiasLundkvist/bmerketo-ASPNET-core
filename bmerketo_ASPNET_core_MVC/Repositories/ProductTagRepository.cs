using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models.Entities;

namespace bmerketo_ASPNET_core_MVC.Repositories;

public class ProductTagRepository : Repo<ProductTagEntity>
{
    public ProductTagRepository(DataContext dataContext) : base(dataContext)
    {
    }
}
