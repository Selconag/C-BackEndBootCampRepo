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
        try
        {

        }
        catch (Exception)
        {

            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {

        }
        catch (Exception)
        {

            throw;
        }
    }

    public List<Cage> GetAll()
    {
        return _cagesData;
    }

    public Cage? GetById(int id)
    {
        Cage? cage = _cagesData.SingleOrDefault(x => x.Id_Cage == id);
        if(cage is not null) return cage;
        return null;
    }
}
