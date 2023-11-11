namespace ZooSystemDB.Data;

public interface IEntityBaseService<TEntity, TId>
{
    void Add(TEntity entity);
    void Delete(TId id);

    List<TEntity> GetAll();

    TEntity? GetById(TId id);

}
