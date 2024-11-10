using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_TASK_USERS")]
    public class TaskUser : DomainEntity<int>
    {

        [Column("TASK_ID")]
        public int TaskId { get; set; }  // Foreign Key to TblTask

        [Column("USER_ID")]
        public int UserId { get; set; }  // Foreign Key to User (assuming there is a User table)

        public TblTask Task { get; set; }
        public User User { get; set; }
    }
}
