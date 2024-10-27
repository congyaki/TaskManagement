using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class RoleHasPermissionsConfiguration : IEntityTypeConfiguration<RoleHasPermissions>
    {
        public void Configure(EntityTypeBuilder<RoleHasPermissions> builder)
        {
            // Composite keys for TblRoleHasPermissions
            builder.HasKey(c => new { c.PermissionId, c.RoleId });

        }
    }
}
