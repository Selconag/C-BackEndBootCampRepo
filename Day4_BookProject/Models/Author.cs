using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Models;

public class Author : EntityBase<int>
{
    public int Id { get; set; }
    public string Name { get; set; }

}
