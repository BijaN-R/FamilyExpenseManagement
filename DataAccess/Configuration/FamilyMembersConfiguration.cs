using Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class FamilyMembersConfiguration : IEntityTypeConfiguration<FamilyMembers>
    {
        public void Configure(EntityTypeBuilder<FamilyMembers> builder)
        {
            builder.HasIndex(i => i.UserName).IsUnique();
            builder.Property(p => p.UserName).IsRequired();
            builder.Property(p => p.Password).IsRequired();
        }
    }
}
