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
    public class BankAccountsConfiguration : IEntityTypeConfiguration<BankAccounts>
    {
        public void Configure(EntityTypeBuilder<BankAccounts> builder)
        {
            builder.Property(p => p.BankName).IsRequired();
        }
    }
}
