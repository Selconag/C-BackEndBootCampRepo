namespace ZooSystemDB.Exceptions;

public class AnimalIdException: Exception
{
    public AnimalIdException(int id) :
        base($"Id : {id}, ye ait hayvan bulunamadı.")
    {

    }
}