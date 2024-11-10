using System.ComponentModel.DataAnnotations.Schema;
using TaskManagement.Entities;
using TaskManagement.Models.Comment.Query;
using TaskManagement.Models.Label.Query;
using TaskManagement.Models.User.Query;

namespace TaskManagement.Models.Task.Query
{
    public class TaskQueryDto
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
        public List<LabelQueryDto> Labels { get; set; }
        public List<UserQueryDto> Users { get; set; }
        public List<CommentQueryDto> Comments { get; set; }
        public IFormFileCollection? TaskFiles { get; set; }
    }
}
