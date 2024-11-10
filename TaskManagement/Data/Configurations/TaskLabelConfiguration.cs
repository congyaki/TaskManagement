using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class TaskLabelConfiguration : IEntityTypeConfiguration<TaskLabel>
    {
        public void Configure(EntityTypeBuilder<TaskLabel> builder)
        {
            builder.HasOne(u => u.Task)
                .WithMany(d => d.TaskLabels)
                .HasForeignKey(u => u.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.Label)
                .WithMany(d => d.TaskLabels)
                .HasForeignKey(u => u.LabelId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
