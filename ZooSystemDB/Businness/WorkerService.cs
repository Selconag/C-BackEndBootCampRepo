using ZooSystemDB.Data;
using ZooSystemDB.Exceptions;

namespace ZooSystemDB.Businness;

public class WorkerService : IWorkerService
{
    private readonly IWorkerRepository _workerRepo;

    public WorkerService(IWorkerRepository workerRepo)
    {
        //AuthorRepository instance ını kullanarak işlemleri götüreceğiz.
        _workerRepo = workerRepo;
    }

    public void Add(Worker entity)
    {
        //Validasyon kuralları ekle
        try
        {
            //validasyonu kontrol et(exception atarsa çık) No validation for now
            //AddRules(entity);
            //Sorun yoksa devam et ve ekle
            _workerRepo.Add(entity);
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
            _workerRepo.Delete(id);
        }
        catch (Exception ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
        }
    }

    public List<Worker> GetAll()
    {
        return _workerRepo.GetAll();
    }

    public Worker? GetById(int id)
    {
        try
        {
            Worker? worker = _workerRepo.GetById(id);
            Console.WriteLine(worker);
            return worker;
        }
        catch (EntityIdException<int> ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public bool AttendedAllAnimalsAtCage(int cageId)
    {
        throw new NotImplementedException();
    }

    public bool AttendedAnimalAtCage(int animalId)
    {
        throw new NotImplementedException();
    }

    public List<Animal> ListAttendedCageAnimals()
    {
        throw new NotImplementedException();
    }

    public List<Cage> ListAttendedCages()
    {
        throw new NotImplementedException();
    }
}
