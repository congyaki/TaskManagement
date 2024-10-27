using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class ModelHasPermissionsConfiguration : IEntityTypeConfiguration<ModelHasPermissions>
    {
        public void Configure(EntityTypeBuilder<ModelHasPermissions> builder)
        {
            builder.HasKey(c => new { c.PermissionId, c.ModelMorphKey, c.TeamForeignKey });
        }
    }
}
