using CongestionTaxCalculator.Domain.Shared.Interfaces;

namespace CongestionTaxCalculator.Infrastructure.Data
{
    public class BaseUnitOfWork : IBaseUnitOfWork
    {
        private readonly AppDbContext _context;

        public BaseUnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public AppDbContext AppDbContext() => _context;


        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
