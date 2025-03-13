using Microsoft.EntityFrameworkCore;
using FinanceTrackerApi.Models;

namespace FinanceTrackerApi.Data
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
            : base(options) { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
