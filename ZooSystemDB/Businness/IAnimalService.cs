using System.Security.Cryptography;
using ZooSystemDB.Data;

namespace ZooSystemDB.Businness;

internal interface IAnimalService
{
    void Add(Animal entity);
    void Delete(int id);

    List<Animal> GetAll();

    Animal? GetById(int id);


}
