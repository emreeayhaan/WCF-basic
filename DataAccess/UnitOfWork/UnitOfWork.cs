using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitofWork
{
    /// <summary>
    /// <T> almak zorundasın çünkü generic bir tip. Diğer tarafta tanıtınca burda da tanıtmak zorunasın.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UnitofWork<T> : IUnitofWork<T>
    {
        private DbContext _context;

        public UnitofWork(DbContext context)
        {
            _context = context;
        }
        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(_context);
        }
        public int Save()
        {

            _context.Configuration.LazyLoadingEnabled = false;
            return _context.SaveChanges();

        }
        public void Dispose()
        {
            _context.Dispose();
            /// <summary>
            /// DIPONSE : görevi biten objectleri (nesneleri) çağırarak arka planda ekstra çalışmamasını sağlar.Class tipi objectlere uygulanır.
            /// </summary>
        }
    }
}
