namespace CongestionTaxCalculator.Domain.Shared.Interfaces
{
    public interface IBaseUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync();

    }
}
