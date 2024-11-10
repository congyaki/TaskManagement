using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Models.Task.Command
{
    public class TaskCommandDto
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
        public IEnumerable<int> UserIds { get; set; }
        public IEnumerable<int> LabelIds { get; set; }
        public IFormFileCollection Files { get; set; }
    }
}
