using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskManagement.enums;
using TaskStatus = TaskManagement.enums.TaskStatus;

namespace TaskManagement.Entities
{
    [Table("TBL_TASKS")]
    public class TblTask : DomainEntity<int>
    {

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("START_DATE")]
        public DateTime? StartDate { get; set; }

        [Column("END_DATE")]
        public DateTime? EndDate { get; set; }

        [Column("PRIORITY")]
        public int? Priority { get; set; }

        [Column("ESTIMATED_TIME")]
        public double? EstimatedTime { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

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
    }
}
