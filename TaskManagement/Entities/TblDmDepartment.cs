using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_DM_DEPARTMENTS")]
    public class TblDmDepartment : DomainEntity<int>
    {

        [Column("CODE")]
        public string Code { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        public List<User> Users { get; set; }
    }
}
