using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSystemDB.Data;

public class AnimalRepository : IAnimalRepository
{
    private List<Animal> _animalsData = new List<Animal>();

    public AnimalRepository()
    {
        _animalsData.Add(
            new Animal { }

            );
    }

    public void Add(Animal entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Animal> GetAll()
    {
        throw new NotImplementedException();
    }

    public Animal? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
