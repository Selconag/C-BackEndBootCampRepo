using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Exceptions;

public class AuthorIdException : Exception
{
    public AuthorIdException(int id) :
        base($"Id : {id}, ye ait yazar bulunamadı.")
    {

    }
}
