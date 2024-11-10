using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class TaskUserConfiguration : IEntityTypeConfiguration<TaskUser>
    {
        public void Configure(EntityTypeBuilder<TaskUser> builder)
        {
            builder.HasOne(u => u.Task)
                .WithMany(d => d.TaskUsers)
                .HasForeignKey(u => u.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.User)
                .WithMany(d => d.TaskUsers)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
