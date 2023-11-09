namespace ZooSystemDB.Exceptions;

public class Animal : Exception
{
    public AuthorIdException(int id) :
        base($"Id : {id}, ye ait yazar bulunamadı.")
    {

    }
}