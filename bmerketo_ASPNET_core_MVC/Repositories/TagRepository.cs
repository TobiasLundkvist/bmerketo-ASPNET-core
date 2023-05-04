using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Models.Entities;

namespace bmerketo_ASPNET_core_MVC.Repositories
{
    public class TagRepository : Repo<TagEntity>
    {
        public TagRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
