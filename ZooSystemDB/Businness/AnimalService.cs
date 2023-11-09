using ZooSystemDB.Data;
using ZooSystemDB.Exceptions;

namespace ZooSystemDB.Businness;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepo;

    public AnimalService(IAnimalRepository animalRepo)
    {
        //AuthorRepository instance ını kullanarak işlemleri götüreceğiz.
        _animalRepo = animalRepo;
    }

    public void Add(Animal entity)
    {
        //Validasyon kuralları ekle
        try
        {
            //validasyonu kontrol et(exception atarsa çık) No validation for now
            //AddRules(entity);
            //Sorun yoksa devam et ve ekle
            _animalRepo.Add(entity);
        }
        catch (Exception ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int id)
    {
        //Silme işleminde validasyona gerek yok
        //Ancak id nin geçerli olup olmadığına bakmaya gerek var
        try
        {
            _animalRepo.Delete(id);
        }
        catch (Exception ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
        }
    }

    public List<Animal> GetAll()
    {
        return _animalRepo.GetAll();
    }

    public Animal? GetById(int id)
    {
        try
        {
            Animal? animal = _animalRepo.GetById(id);
            Console.WriteLine(animal);
            return animal;
        }
        catch (EntityIdException<int> ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}
