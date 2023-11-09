namespace Zoo;

public class AuthorIdException : Exception
{
    public AuthorIdException(int id) :
        base($"Id : {id}, ye ait yazar bulunamadı.")
    {

    }
}