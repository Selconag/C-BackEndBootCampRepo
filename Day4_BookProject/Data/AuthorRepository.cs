using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day4_BookProject.Data;

public class AuthorRepository : IAuthorRepository
{
    private readonly List<Author> _authorData;

    public AuthorRepository()
    {
        //Oluşturucu kısındayken veri ekle
        _authorData = new List<Author>()
        {
            new Author{Id=1,Name="Anthny Burgess"},
            new Author{Id=2,Name="J. K. Rowling"},
            new Author{Id=3,Name="Stephen King"},
            new Author{Id=4,Name="J. R. R. Tolkien"},
            new Author{Id=5,Name="George R. R. Martin"},
            new Author{Id=6,Name="Johan Huizinga"},
        };
    }

    public void Add(Author author)
    {
        _authorData.Add(author);
    }

    public void Delete(string name)
    {
        Author? author = _authorData.Where(x => x.Name == name).SingleOrDefault();
        if (author is null)
        {
            //throw new Author Exception
            throw new AuthorNameException(name);
        }
        _authorData.Remove(author);
    }

    public void Delete(int id)
    {
        Author? author = _authorData.Where(x => x.Id == id).SingleOrDefault();
        if (author is null)
        {
            //throw new Author Exception
            throw new AuthorIdException(id);
        }
        _authorData.Remove(author);
    }

    public List<Author> GetAll()
    {
        return _authorData;
    }

    public Author? GetById(int id)
    {
        Author? author =  _authorData.SingleOrDefault(p => p.Id == id);
        if (author is not null)
        {
            //throw new Author Exception
            return author;

        }
        return null;
    }
}
