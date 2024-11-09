using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<TblComment>
    {
        public void Configure(EntityTypeBuilder<TblComment> builder)
        {
            builder.HasOne<Entities.TblTask>()
            .WithMany()
            .HasForeignKey(c => c.TaskId);
        }
    }
}
