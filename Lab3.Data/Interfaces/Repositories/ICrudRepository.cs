using Lab3.DAL.Entities;

namespace Lab3.DAL.Interfaces.Repositories;

public interface ICrudRepository<TEntity>
    where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll();
    IQueryable<TEntity> Get(Guid id);

    void Create(TEntity entity);

    Task Update(Guid id, TEntity entity);

    void Delete(TEntity entity);
    Task Delete(Guid id);
}
