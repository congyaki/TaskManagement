using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_DM_DEPARTMENTS")]
    public class TblDmDepartment : BaseEntity<int>
    {

        [Column("CODE")]
        [Display(Name ="Mã bộ môn")]
        public string Code { get; set; }

        [Column("NAME")]
        [Display(Name = "Tên bộ môn")]
        public string Name { get; set; }

        [Column("CREATED_BY")]
        [Display(Name = "Mô tả")]
        public string CreatedBy { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "Mã bộ môn")]
        public DateTime CreatedAt { get; set; }

        [Column("LAST_MODIFIED_BY")]
        [Display(Name = "Mã bộ môn")]
        public string LastModifiedBy { get; set; }

        [Column("LAST_MODIFIED_AT")]
        [Display(Name = "Mã bộ môn")]
        public DateTime? LastModifiedAt { get; set; }
    }
}
