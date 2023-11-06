using Day4_BookProject.Models;

namespace Day4_BookProject.Business;

//Bu interface in bir base interface i bulunmamaktadır. Bu sebeple metodlar elle girilip tanıtılmıştır.
internal interface IAuthorService : IEntityBaseService<Author, int>
{

}