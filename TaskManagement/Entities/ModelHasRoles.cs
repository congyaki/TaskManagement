using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_MODEL_HAS_ROLES")]
    public class ModelHasRoles
    {
        [Key, Column("ROLE_ID")]
        public int RoleId { get; set; }

        [Column("MODEL_TYPE")]
        public string ModelType { get; set; }

        [Column("MODEL_MORPH_KEY")]
        public int ModelMorphKey { get; set; }

        [Column("TEAM_FOREIGN_KEY")]
        public int TeamForeignKey { get; set; }

        // Navigation Properties (nếu cần)
        public virtual Role Role { get; set; }
    }
}
