using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_TASK_LABELS")]
    public class TaskLabel : DomainEntity<int>
    {

        [Column("TASK_ID")]
        public int TaskId { get; set; }

        [Column("LABEL_ID")]
        public int LabelId { get; set; }

        public TblTask Task { get; set; }
        public TblDmLabel Label { get; set; }
    }
}
