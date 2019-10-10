using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RestPOCOTest.Interfaces;

namespace RestPOCOTest.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext DbContext;
        public Repository(DbContext dbContext) => this.DbContext = dbContext;
        public IEnumerable<TEntity> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
