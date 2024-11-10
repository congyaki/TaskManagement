using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_FAILED_JOBS")]
    public class TblFailedJob : DomainEntity<int>
    {

        [Required]
        [Column("UUID")]
        public Guid Uuid { get; set; }

        [Column("CONNECTION")]
        public string Connection { get; set; }

        [Column("QUEUE")]
        public string Queue { get; set; }

        [Column("PAYLOAD")]
        public string Payload { get; set; }

        [Column("EXCEPTION")]
        public string Exception { get; set; }

        [Column("FAILED_AT")]
        public DateTime FailedAt { get; set; }
    }
}
