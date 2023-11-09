using ZooSystemDB.Data;
using ZooSystemDB.Exceptions;

namespace ZooSystemDB.Businness;

public class CageService : ICageService
{
    //If you want to add, delete or update you must use ICageService interface instance to do it
    private readonly ICageRepository _cageRepo;

    public CageService(ICageRepository cageRepo)
    {
        //AuthorRepository instance ını kullanarak işlemleri götüreceğiz.
        _cageRepo = cageRepo;
    }

    public void Add(Cage entity)
    {
        //Validasyon kuralları ekle
        try
        {
            //validasyonu kontrol et(exception atarsa çık) No validation for now
            //AddRules(entity);
            //Sorun yoksa devam et ve ekle
            _cageRepo.Add(entity);
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
            _cageRepo.Delete(id);
        }
        catch (Exception ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
        }
    }

    public List<Cage> GetAll()
    {
        return _cageRepo.GetAll();
    }

    public Cage? GetById(int id)
    {
        try
        {
            Cage? cage = _cageRepo.GetById(id);
            Console.WriteLine(cage);
            return cage;
        }
        catch (EntityIdException<int> ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}
