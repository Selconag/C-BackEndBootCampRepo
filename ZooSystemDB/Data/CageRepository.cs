using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSystemDB.Data;

public class CageRepository : ICageRepository
{
    private List<Cage> _cagesData = new List<Cage>();

    public CageRepository()
    {
        _cagesData.Add(
            new Cage { }
            
            );
    }

    public void Add(Cage entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Cage> GetAll()
    {
        throw new NotImplementedException();
    }

    public Cage? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
