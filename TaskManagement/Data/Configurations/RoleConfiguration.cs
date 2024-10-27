using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasIndex(r => r.Name)
            .IsUnique();

            builder.HasIndex(r => r.GuardName)
            .IsUnique();

            builder.HasIndex(r => r.TeamForeignKey)
                .IsUnique();
        }
    }
}
