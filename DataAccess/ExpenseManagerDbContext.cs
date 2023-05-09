using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Domains;

namespace DataAccess
{
    public class ExpenseManagerDbContext : DbContext
    {
        public ExpenseManagerDbContext(DbContextOptions<ExpenseManagerDbContext> options) : base(options)
        {
        }


        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<FamilyMembers> FamilyMembers { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<TransActionCategories> TransActionCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Persian_100_CI_AS");
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.LogTo(msg => Debug.WriteLine(msg)).EnableSensitiveDataLogging();

        //        optionsBuilder.UseSqlServer(AppSettings.ConnectionString);
        //    }
        //}
    }
}
