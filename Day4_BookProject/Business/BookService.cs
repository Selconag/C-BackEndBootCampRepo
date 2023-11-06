
using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;

namespace Day4_BookProject.Business;


// Dependency Injection  (Constructor args Injection, Setter injection, method injection)
// AddScopped , AddSingleton, AddTransient


// Single Responsibilitiy 
// Open Closed
// Liskov subs. 
// Interface segre.
// Dependency Inversion  
public class BookService :IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    // Ekleme işi yaparken kitap başlığı minimum 2 karakterli olmalıdır.
    // Price ve Stock Property leri - değer alamaz.
    public void Add(Book book)
    {
        // Validasyon kurallarından geçmeyen kitabı listeye eklemeyeceğiz.
        try
        {
            //Kurallarıkontrol et
            AddRules(book);
            //Uygunsa kitabı eklemeye gönder
            _bookRepository.Add(book);
            //Sonuç listeyi al
            GetList();
        }
        //Bir istisna gerçekleştiyse gir
        catch (Exception ex)
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
        }


        // 1. Yöntem
        //catch (BookTitleException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (BookPriceAndStockException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }

    //Kitabı silme çağrısı
    public void Delete(int id)
    {
        try
        {
            //Kitabı sil
            _bookRepository.Delete(id);
            //Sonuç listeyi al
            GetList();
        }
        //Bir istisna gerçekleştiyse gir
        catch (BookNotFoundException ex) 
        {
            //İstisna durumunu yazdır
            Console.WriteLine(ex.Message);
        }
    }

    //Kitabı Id verisine göre getir
    public void GetById(int id)
    {
        try
        {
            Book? book = _bookRepository.GetById(id);
            Console.WriteLine(book);

        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public void GetByIsbn(string isbn)
    {
        try
        {
            Book? book = _bookRepository.GetByIsbn(isbn);
            Console.WriteLine(book);

        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //Kitaplar listesini getir
    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach(book => Console.WriteLine(book));
    }

    //İstisnai durumları kontrol et, varsa uyarı mesajı oluştur
    private void AddRules(Book book)
    {
        if (book.Title.Length < 2)
        {
            throw new BookTitleException(book.Title);
        }

        if (book.Price<0 || book.Stock < 0)
        {
            throw new BookPriceAndStockException(book.Price,book.Stock);
        }
    }

}
