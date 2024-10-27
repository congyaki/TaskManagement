using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_ROLE_HAS_PERMISSIONS")]
    public class RoleHasPermissions
    {
        [Key, Column("PERMISSION_ID")]
        public int PermissionId { get; set; }

        [Key, Column("ROLE_ID")]
        public int RoleId { get; set; }

        // Navigation Properties (nếu cần)
        public virtual Role Role { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
