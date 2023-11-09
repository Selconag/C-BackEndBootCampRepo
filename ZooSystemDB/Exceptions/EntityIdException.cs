namespace ZooSystemDB.Exceptions;

public class EntityIdException<TId>: Exception
{
    public EntityIdException(TId id) :
        base($"Id : {id}, ye ait bilgi bulunamadı.")
    {

    }
}