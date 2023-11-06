using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Exceptions;

public class AuthorNameException : Exception
{
    public AuthorNameException(string name) :
        base($"İsim : {name}, ye ait yazar bulunamadı.")
    {

    }
}
