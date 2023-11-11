using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSystemDB.Data;

public interface IAnimalRepository : IEntityRepositoryBase<Animal, int>
{
    public bool AttendAnimal(int id);
}
