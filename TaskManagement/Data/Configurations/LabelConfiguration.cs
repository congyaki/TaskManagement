using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class LabelConfiguration : IEntityTypeConfiguration<TblDmLabel>
    {
        public void Configure(EntityTypeBuilder<TblDmLabel> builder)
        {
            builder.HasMany(d => d.TaskLabels)
                .WithOne(u => u.Label)
                .HasForeignKey(u => u.LabelId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
