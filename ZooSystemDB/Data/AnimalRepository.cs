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
        try
        {

        }
        catch (Exception)
        {

            throw;
        }
    }

    //Return true if animal is attended;
    public bool AttendAnimal(int id)
    {
        Animal? animal = _animalsData.SingleOrDefault(x => x.Id_Animal == id);
        if (animal is not null)
        {
            animal.LastAttended = DateTime.Now;
            return true; 
        }
        else return false;
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

    public List<Animal> GetAll()
    {
        return _animalsData;
    }

    public Animal? GetById(int id)
    {
        Animal? animal = _animalsData.SingleOrDefault(x => x.Id_Animal == id);
        if(animal is not null) return animal;
        return null;
    }
}
