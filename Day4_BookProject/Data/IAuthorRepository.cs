using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Data;

//Interface içinde dönecek tipler generic çağrıda belirtildiği için (override edildiği için) çağrılarda problem oluşmayacaktır
//Burada override edilen tip TEntity ve TId  => Author ve int olarak belirlendi.
//Bu durum sayesinde ek bir metod kullanılmaması gerekmemektedir.
public interface IAuthorRepository : IEntityBaseRepository<Author, int>
{

}
