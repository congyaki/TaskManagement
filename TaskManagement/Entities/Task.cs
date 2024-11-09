using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_TASKS")]
    public class Task
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Display(Name ="Tiêu Đề")]
        [Column("TITLE")]
        public string Title { get; set; }

        [Display(Name = "Thời gian bắt đầu")]
        [Column("START_DATE")]
        public DateTime? StartDate { get; set; }

        [Display(Name ="Thời gian kết thúc")]
        [Column("END_DATE")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Mức độ ưu tiên")]
        [Column("PRIORITY")]
        public int? Priority { get; set; }

        [Column("ESTIMATED_TIME")]
        public double? EstimatedTime { get; set; }

        [Display(Name = "Mô tả")]
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Display(Name = "Trạng thái")]
        [Column("STATUS")]
        public string Status { get; set; }

        [Display(Name = "Tạo bởi")]
        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }

        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }

        [Column("LAST_MODIFIED_BY")]
        public string LastModifiedBy { get; set; }

        [Column("LAST_MODIFIED_AT")]
        public DateTime? LastModifiedAt { get; set; }

        [Column("DEPARTMENT_ID")]
        public int DepartmentId { get; set; }  // Foreign Key

        [Column("PARENT_ID")]
        public int? ParentId { get; set; }  // Foreign Key (Self reference)
    }
}
