using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSystemDB.Data;

public class WorkerRepository : IWorkerRepository
{
    private List<Worker> _workersData = new List<Worker>();

    public WorkerRepository()
    {
        //Oluşturucu kısındayken veri ekle
        _workersData = new List<Worker>()
        {
            new Worker { Id_Worker = 1, Id_AttendedCages = new int[] { 1, 2, 3 }, Name = "John Smith", Phone = "+1234567890", WorkDays = new WorkDays[] { WorkDays.Monday, WorkDays.Wednesday, WorkDays.Friday } },
            new Worker { Id_Worker = 2, Id_AttendedCages = new int[] { 4, 5, 6 }, Name = "Jane Johnson", Phone = "+9876543210", WorkDays = new WorkDays[] { WorkDays.Tuesday, WorkDays.Thursday } },
            new Worker { Id_Worker = 3, Id_AttendedCages = new int[] { 7, 8, 9 }, Name = "Michael Brown", Phone = "+5551234567", WorkDays = new WorkDays[] { WorkDays.Monday, WorkDays.Wednesday } },
            new Worker { Id_Worker = 4, Id_AttendedCages = new int[] { 0 }, Name = "Emily Davis", Phone = "+8889990000", WorkDays = new WorkDays[] { WorkDays.Friday } },
            new Worker { Id_Worker = 5, Id_AttendedCages = new int[] { 2, 4, 6, 8 }, Name = "Daniel Wilson", Phone = "+1234509876", WorkDays = new WorkDays[] { WorkDays.Tuesday, WorkDays.Thursday, WorkDays.Saturday } }

        };
    }
    
    public void Add(Worker entity)
    {
        //Check for errors when adding
        try
        {
            _workersData.Add(entity);
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
            Worker? worker = _workersData.SingleOrDefault(x => x.Id_Worker == id);
            _workersData.Remove(worker);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public List<Worker> GetAll()
    {
        //_workersData.ForEach(x => Console.WriteLine(x));
        return _workersData;
    }

    public Worker? GetById(int id)
    {
       Worker? worker =  _workersData.SingleOrDefault(x => x.Id_Worker == id);
        if(worker is not null) return worker;
        else return null;
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
