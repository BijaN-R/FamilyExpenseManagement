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
    public class TransactionCategoriesConfiguration : IEntityTypeConfiguration<TransactionCategories>
    {
        public void Configure(EntityTypeBuilder<TransactionCategories> builder)
        {
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
