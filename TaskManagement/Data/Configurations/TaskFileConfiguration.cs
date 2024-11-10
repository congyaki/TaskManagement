using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class TaskFileConfiguration : IEntityTypeConfiguration<TaskFile>
    {
        public void Configure(EntityTypeBuilder<TaskFile> builder)
        {
            builder.HasOne(u => u.Task)
                .WithMany(d => d.TaskFiles)
                .HasForeignKey(u => u.TaskId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
