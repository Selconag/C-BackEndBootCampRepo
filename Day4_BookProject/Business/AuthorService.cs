using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Business;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        //AuthorRepository instance ını kullanarak işlemleri götüreceğiz.
        _authorRepository = authorRepository;
    }

    public void Add(Author author)
    {
        //Validasyon kuralları ekle
        try
        {
            //validasyonu kontrol et
            AddRules(author);
            //Sorun yoksa devam et ve ekle
            _authorRepository.Add(author);
            //Sonuç listeyi al
            GetList();
        }
        catch (Exception ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
        }
    }

    //Belirtilen Id deki kişiyi sil
    public void Delete(int Id)
    {
        //Silme işleminde validasyona gerek yok
        //Ancak id nin geçerli olup olmadığına bakmaya gerek var
        try
        {
            _authorRepository.Delete(Id);
            //Sonuç listeyi al
            GetList();
        }
        catch (Exception ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int id)
    {
        try
        {
            Author? author = _authorRepository.GetById(id);
            Console.WriteLine(author);
        }
        catch (AuthorIdException ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Author> list = _authorRepository.GetAll();
        list.ForEach(author => Console.WriteLine(author));
    }

    //İstisnai durumları kontrol et, varsa uyarı mesajı oluştur
    private void AddRules(Author author)
    {
        if (author.Name.Length < 2)
        {
            throw new BookTitleException(author.Name);
        }

    }
}
