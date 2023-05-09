using Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class TransactionsConfiguration : IEntityTypeConfiguration<Transactions>
    {
        public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.Property(p => p.TransactionType).IsRequired();
            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.Title).IsRequired();
            builder.HasOne(p => p.Category).WithMany(p => p.Transactions).HasForeignKey(p => p.CategoryId);
            builder.HasOne(p => p.BankAccount).WithMany(p => p.Transactions).HasForeignKey(p => p.BankAccountId);
            builder.HasOne(p => p.FamilyMember).WithMany(p => p.Transactions).HasForeignKey(p => p.FamilyMemberId);

        }
    }
}
