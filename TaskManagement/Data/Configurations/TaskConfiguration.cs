using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Entities.TblTask>
    {
        public void Configure(EntityTypeBuilder<Entities.TblTask> builder)
        {
            //builder.HasOne<TblDmDepartment>()
            //.WithMany()
            //.HasForeignKey(t => t.DepartmentId);

            //builder.HasOne<Entities.TblTask>()
            //.WithMany()
            //.HasForeignKey(t => t.ParentId);

            builder.HasMany(d => d.TaskLabels)
                .WithOne(u => u.Task)
                .HasForeignKey(u => u.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(d => d.TaskUsers)
                .WithOne(u => u.Task)
                .HasForeignKey(u => u.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(d => d.Comments)
                .WithOne(u => u.Task)
                .HasForeignKey(u => u.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(d => d.TaskFiles)
                .WithOne(u => u.Task)
                .HasForeignKey(u => u.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(t => t.Status)
                .HasConversion<string>();
        }
    }
}
