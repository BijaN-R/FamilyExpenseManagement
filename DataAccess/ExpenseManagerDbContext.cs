using Microsoft.EntityFrameworkCore;
using Domains;
using DataAccess.Configuration;

namespace DataAccess
{
    public class ExpenseManagerDbContext : DbContext
    {
        public ExpenseManagerDbContext(DbContextOptions<ExpenseManagerDbContext> options) : base(options)
        {
        }


        public DbSet<BankAccounts> BankAccounts { get; set; }
        public DbSet<FamilyMembers> FamilyMembers { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<TransactionCategories> TransactionCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Persian_100_CI_AS");
            modelBuilder.ApplyConfiguration(new FamilyMembersConfiguration());
            modelBuilder.ApplyConfiguration(new BankAccountsConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionCategoriesConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
