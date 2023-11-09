public class Messages
{
    //Bu kısım hata mesajı olarak kullanılmayacak bilgilendirme mesajları içindir.
    public static string AnimalNotFoundException(string animal)
    {
        return $"Aradığınız {animal} hayvan bulunamadı";
    }
}