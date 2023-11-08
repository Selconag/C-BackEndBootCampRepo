using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSystemDB.Data;

public interface IEntityRepositoryBase<TEntity, TId>
{
    void Add(TEntity entity);
    void Delete(TId id);

    List<TEntity> GetAll();

    TEntity? GetById(TId id);

}