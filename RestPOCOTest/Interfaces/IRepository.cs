using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPOCOTest.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllProducts();
    }
}
