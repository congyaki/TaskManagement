using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Entities
{
    [Serializable]
    public class DomainEntity<T>
    {
        [Key]
        [Column("ID")]
        public virtual T Id { get; set; }

        [Column("CREATED_BY")]
        [Display(Name = "Tạo bởi")]
        public int? CreatedBy { get; set; }

        [Column("CREATED_AT")]
        public DateTime? CreatedAt { get; set; }

        [Column("LAST_MODIFIED_BY")]
        public int? LastModifiedBy { get; set; }

        [Column("LAST_MODIFIED_AT")]
        public DateTime? LastModifiedAt { get; set; }
    }
}
