using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSystemDB.Data;

public class Cage
{
    public int Id_Cage { get; set; }
    public string CageName { get; set; }
    public AnimalType CageType { get; set; }
    //Holds only animal Id's for performance purposes
    public List<int> AnimalList { get; set; }
    //Holds only worker Id's for performance purposes
    public List<int> WorkerList { get; set; }


}
