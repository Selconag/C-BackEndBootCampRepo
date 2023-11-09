using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace ZooSystemDB.Data;

public interface IWorkerRepository : IEntityRepositoryBase<Worker, int>
{
    public List<Cage> ListAttendedCages();
    public List<Animal> ListAttendedCageAnimals();
    public bool AttendedAnimalAtCage(int animalId);
    public bool AttendedAllAnimalsAtCage(int cageId);
}
