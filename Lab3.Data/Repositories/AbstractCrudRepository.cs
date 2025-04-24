using Lab3.DAL.Entities;
using Lab3.DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Lab3.DAL.Repositories;

public class AbstractCrudRepository<TEntity>(ShopContext context) : ICrudRepository<TEntity>
    where TEntity : BaseEntity
{
    private readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();

    public IQueryable<TEntity> GetAll()
    {
        return _dbSet;
    }

    public IQueryable<TEntity> Get(Guid id)
    {
        return _dbSet.Where(e => e.Id == id);
    }

    public void Create(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public void Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task Delete(Guid id)
    {
        var entity = await _dbSet.FindAsync(id)
            ?? throw new ArgumentException("Not existing id was provided.", nameof(id));

        _dbSet.Remove(entity);
    }

    public async Task Update(Guid id, TEntity entity)
    {
        var currentEntity = await _dbSet.FindAsync(id)
            ?? throw new ArgumentException("Not existing id was provided.", nameof(id));

        context.Entry(currentEntity).CurrentValues.SetValues(entity);
    }
}
