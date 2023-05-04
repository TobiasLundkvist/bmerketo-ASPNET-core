using bmerketo_ASPNET_core_MVC.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bmerketo_ASPNET_core_MVC.Repositories;

public abstract class Repo<TEntity> where TEntity : class
{
    private readonly DataContext _dataContext;
    protected Repo(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    // Create something
    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        _dataContext.Set<TEntity>().Add(entity);
        await _dataContext.SaveChangesAsync();
        return entity;
    }

    // Get one item
    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var entity = await _dataContext.Set<TEntity>().FirstOrDefaultAsync(predicate);
        return entity!;
    }

    // Get all items
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        var entities = await _dataContext.Set<TEntity>().ToListAsync();
        return entities;
    }
}
