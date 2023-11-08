using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSystemDB.Data;

namespace ZooSystemDB.Businness;

internal interface IWorkerService
{
    void Add(Worker entity);
    void Delete(int id);

    List<Worker> GetAll();

    Worker? GetById(int id);
}
