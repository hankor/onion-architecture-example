using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly DbContext _dbContext;
    protected DbSet<T> Entities => _dbContext.Set<T>();

    public GenericRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IList<T> GetAll() => Entities.ToList();

    public void Insert(T entity)
    {
        Entities.Add(entity);
    }
}