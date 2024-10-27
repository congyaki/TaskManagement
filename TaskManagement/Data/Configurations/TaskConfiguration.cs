using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Entities.Task>
    {
        public void Configure(EntityTypeBuilder<Entities.Task> builder)
        {
            builder.HasOne<Department>()
            .WithMany()
            .HasForeignKey(t => t.DepartmentId);

            builder.HasOne<Entities.Task>()
            .WithMany()
            .HasForeignKey(t => t.ParentId);
        }
    }
}
