using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet.Domain;

namespace myfinance_web_dotnet.Infrastructure
{
    public class MyFinanceDbContext : DbContext
    {
        public required DbSet<PlanoConta> PlanoConta { get; set; }
        public required DbSet<Transacao> Transacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source=./myfinanceweb.db";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}