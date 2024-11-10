using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<TblDmDepartment>
    {
        public void Configure(EntityTypeBuilder<TblDmDepartment> builder)
        {
            builder.HasMany(d => d.Users)
                .WithOne(u => u.Department)
                .HasForeignKey(u => u.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
