namespace ZooSystemDB.Exceptions;

public class AnimalIdException: Exception
{
    public AnimalIdException(int id) :
        base($"Id : {Id_Animal}, ye ait hayvan bulunamadı.")
    {

    }
}