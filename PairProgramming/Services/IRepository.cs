namespace PairProgramming.Services;

public interface IRepository<TEntity>
{
    List<TEntity> GetAll();
}