using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskManagement.enums;
using TaskStatus = TaskManagement.enums.TaskStatus;

namespace TaskManagement.Entities
{
    [Table("TBL_TASKS")]
    public class TblTask : DomainEntity<int>
    {

        [Display(Name ="Tiêu Đề")]
        [Column("TITLE")]
        public string Title { get; set; }
        [Column("CODE")]
        public string Code { get; set; }

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
        public TaskStatus Status { get; set; }

        //[Column("DEPARTMENT_ID")]
        //public int DepartmentId { get; set; }

        [Column("PARENT_ID")]
        public int? ParentId { get; set; }
        //public TblDmDepartment Department { get; set; }
        public List<TaskLabel> TaskLabels { get; set; }
        public List<TaskUser> TaskUsers { get; set; }
        public List<TblComment> Comments { get; set; }
        public List<TaskFile> TaskFiles { get; set; }
    }
}
