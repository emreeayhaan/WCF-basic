using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess.Repository
{// Repository Pattern Veritabanına veri ekleme,
 // güncelleme ve okuma gibi CRUD (Create Read Update Delete)
 // işlemlerimiz için oluşturmuş olduğumuz kodların tekrar kullanılabilirliğini sağlamaktır.
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext _context;
        protected DbSet<T> _dbset;
        public Repository(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public void Add(T entity)
        {
         _context.Set<T>().Add(entity);
        }
        public void Delete(T entity)
        {
            _dbset.Attach(entity);
            _dbset.Remove(entity);
        }

        public void Get(int id)
        {
            _dbset.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> condition)
        {
            return _dbset.Where(condition).ToList();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();

        }
        public void Update(T entity)
        {
            _dbset.Attach(entity);
        }
    }
}
