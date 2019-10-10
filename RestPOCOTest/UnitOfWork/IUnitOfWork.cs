namespace RestPOCOTest.UnitOfWork
{
    using Interfaces;
    using System;
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository IProductRepository { get; }
    }
}
