using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_JOBS")]
    public class Job : BaseEntity<int>
    {

        [Column("QUEUE")]
        public string Queue { get; set; }

        [Column("PAYLOAD")]
        public string Payload { get; set; }

        [Column("ATTEMPTS")]
        public int Attempts { get; set; }

        [Column("RESERVED_AT")]
        public DateTime? ReservedAt { get; set; }

        [Column("AVAILABLE_AT")]
        public DateTime? AvailableAt { get; set; }

        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }
    }
}
