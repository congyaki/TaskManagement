using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class TaskLabelConfiguration : IEntityTypeConfiguration<TaskLabel>
    {
        public void Configure(EntityTypeBuilder<TaskLabel> builder)
        {
            builder.HasOne<Entities.Task>()
            .WithMany()
            .HasForeignKey(t => t.TaskId);

            builder.HasOne<Label>()
            .WithMany()
            .HasForeignKey(t => t.LabelId);
        }
    }
}
