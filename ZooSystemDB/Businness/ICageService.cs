using ZooSystemDB.Data;

namespace ZooSystemDB.Businness;

internal interface ICageService
{
    void Add(Cage entity);
    void Delete(int id);

    List<Cage> GetAll();

    Cage? GetById(int id);
}
