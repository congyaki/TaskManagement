using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class ModelHasRolesConfiguration : IEntityTypeConfiguration<ModelHasRoles>
    {
        public void Configure(EntityTypeBuilder<ModelHasRoles> builder)
        {
            builder.HasKey(c => new { c.RoleId, c.ModelMorphKey, c.TeamForeignKey });
        }
    }
}
