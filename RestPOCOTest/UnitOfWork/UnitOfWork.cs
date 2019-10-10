namespace RestPOCOTest.UnitOfWork
{
    using Interfaces;
    using Poco;
    using Repositories;
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Dev_CampregistrationContext devCampregistrationContext;

        public UnitOfWork(Dev_CampregistrationContext devCampregistrationContext)
        {
            this.devCampregistrationContext = devCampregistrationContext;
            this.IProductRepository = new ProductRepository(this.devCampregistrationContext);
        }

        public IProductRepository IProductRepository { get; private set; }

        public void Dispose() => this.devCampregistrationContext.Dispose();
    }
}
