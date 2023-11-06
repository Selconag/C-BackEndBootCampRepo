using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Exceptions
{
    public class BookNotFoundWithIsbn : Exception
    {
        public BookNotFoundWithIsbn(string isbn) :
            base($"ISBN : {isbn}, ye ait kitap bulunamadı.") 
        {
        }
       
    }
}
