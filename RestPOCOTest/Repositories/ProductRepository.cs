namespace RestPOCOTest.Repositories
{
    using Interfaces;
    using System.Linq;
    using Poco;
    using Microsoft.EntityFrameworkCore;

    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public Dev_CampregistrationContext dev_CampregistrationContext
        {
            get { return this.DbContext as Dev_CampregistrationContext; }
        }

        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Product GetProduct() => this.dev_CampregistrationContext.Products.SingleOrDefault();
    }
}
