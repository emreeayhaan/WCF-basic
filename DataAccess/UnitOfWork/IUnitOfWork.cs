using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitofWork
{
    /// <summary>
    /// Uyguamayı daha verimli hale getirir ve yapılan iş bittikten sonra bellekten temizlenir.
    /// </summary>
    /// <typeparam name="Disponable"></typeparam>
    public interface IUnitofWork<TEntity> : IDisposable
    {
        IRepository<T> Repository<T>() where T : class;
        int Save();
    }

}
