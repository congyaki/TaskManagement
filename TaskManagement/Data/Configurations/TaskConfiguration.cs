using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Entities.TblTask>
    {
        public void Configure(EntityTypeBuilder<Entities.TblTask> builder)
        {
            builder.HasOne<TblDmDepartment>()
            .WithMany()
            .HasForeignKey(t => t.DepartmentId);

            builder.HasOne<Entities.TblTask>()
            .WithMany()
            .HasForeignKey(t => t.ParentId);
        }
    }
}
