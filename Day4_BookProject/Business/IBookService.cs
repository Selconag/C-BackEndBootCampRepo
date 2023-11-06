

using Day4_BookProject.Models;
using System.Security.Cryptography;

namespace Day4_BookProject.Business;

internal interface IBookService
{
    void GetList();
    void Add(Book book);
    void Delete(int id);
    void GetById(int id);
    void GetByIsbn(string isbn);
}
