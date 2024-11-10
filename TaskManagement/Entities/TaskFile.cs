using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Entities
{
    [Table("TBL_TASK_FILES")]
    public class TaskFile : DomainEntity<int>
    {
        [Column("TASK_ID")]
        public int TaskId { get; set; }
        [Column("FILE_PATH")]
        public string FilePath { get; set; }
        public TblTask Task { get; set; }
    }
}
