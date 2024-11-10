using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_DM_LABELS")]
    public class TblDmLabel : DomainEntity<int>
    {

        [Column("CODE")]
        public string Code { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("COLOR")]
        public string Color { get; set; }
        public List<TaskLabel> TaskLabels { get; set; }
    }
}
