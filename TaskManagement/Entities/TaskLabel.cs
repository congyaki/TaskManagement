using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_TASK_LABELS")]
    public class TaskLabel
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TASK_ID")]
        public int TaskId { get; set; }  // Foreign Key to TblTask

        [Column("LABEL_ID")]
        public int LabelId { get; set; }  // Foreign Key to TblDmLabel

        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }

        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }

        [Column("LAST_MODIFIED_BY")]
        public string LastModifiedBy { get; set; }

        [Column("LAST_MODIFIED_AT")]
        public DateTime? LastModifiedAt { get; set; }
    }
}
