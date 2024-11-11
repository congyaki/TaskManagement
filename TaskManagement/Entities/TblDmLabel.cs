using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_DM_LABELS")]
    public class TblDmLabel : DomainEntity<int>
    {

        [Column("CODE")]
        [Display(Name="Mã nhãn")]
        public string Code { get; set; }

        [Column("NAME")]
        [Display(Name = "Tên nhãn")]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [Display(Name = "Mô Tả")]
        public string Description { get; set; }

        [Column("COLOR")]
        [Display(Name = "Màu nhãn")]
        public string Color { get; set; }
        public List<TaskLabel> TaskLabels { get; set; }
    }
}
