namespace RestPOCOTest.Interfaces
{
    using Poco;
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProduct();
    }
}
