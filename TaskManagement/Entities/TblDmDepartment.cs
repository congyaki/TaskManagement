using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_DM_DEPARTMENTS")]
    public class TblDmDepartment : DomainEntity<int>
    {

        [Column("CODE")]
        [Display(Name ="Mã bộ môn")]
        public string Code { get; set; }

        [Column("NAME")]
        [Display(Name = "Tên bộ môn")]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [Display(Name = "Mô tả")]

        public string Description { get; set; }

        public List<User> Users { get; set; }
    }
}
