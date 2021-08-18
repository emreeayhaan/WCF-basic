using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    // Repository Pattern Veritabanına veri ekleme,
    // güncelleme ve okuma gibi CRUD (Create Read Update Delete)
    // işlemlerimiz için oluşturmuş olduğumuz kodların tekrar kullanılabilirliğini sağlamaktır.
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> condition);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Get(int id);
        IEnumerable<T> GetAll();
    }
}
