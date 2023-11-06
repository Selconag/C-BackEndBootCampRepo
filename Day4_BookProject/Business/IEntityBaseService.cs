namespace Day4_BookProject.Business;

public interface IEntityBaseService<TEntity,TId>
{
    void GetList();
    void Add(TEntity entity);
    void Delete(TId id);
    void GetById(TId id);
}
