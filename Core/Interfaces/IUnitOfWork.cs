namespace Core.Interfaces;

public interface IUnitOfWork
{
    int SaveChanges();
}