using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class TaskLabelConfiguration : IEntityTypeConfiguration<TaskLabel>
    {
        public void Configure(EntityTypeBuilder<TaskLabel> builder)
        {
            builder.HasOne<Entities.TblTask>()
            .WithMany()
            .HasForeignKey(t => t.TaskId);

            builder.HasOne<TblDmLabel>()
            .WithMany()
            .HasForeignKey(t => t.LabelId);
        }
    }
}
