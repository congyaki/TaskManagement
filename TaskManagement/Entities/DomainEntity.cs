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
        [Display(Name = "Người thêm mới")]
        public int? CreatedBy { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "Thời gian thêm mới")]

        public DateTime? CreatedAt { get; set; }

        [Column("LAST_MODIFIED_BY")]
        [Display(Name = "Người chỉnh sửa cuối cùng")]
        public int? LastModifiedBy { get; set; }

        [Column("LAST_MODIFIED_AT")]
        [Display(Name = "Thời gian chỉnh sửa cuối cùng")]

        public DateTime? LastModifiedAt { get; set; }
    }
}
