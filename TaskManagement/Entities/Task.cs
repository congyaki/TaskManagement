using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_TASKS")]
    public class Task : BaseEntity<int>
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
        public string Status { get; set; }

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
