using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Entities
{
    [Table("TBL_USERS")]
    public class User
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("CODE")]
        public string Code { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("EMAIL_VERIFIED_AT")]
        public DateTime? EmailVerifiedAt { get; set; }

        [Column("PASSWORD")]
        public string Password { get; set; }

        [Column("REMEMBER_TOKEN")]
        public string RememberToken { get; set; }

        [Column("BIRTHDAY")]
        public DateTime? Birthday { get; set; }

        [Column("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [Column("ADDRESS")]
        public string Address { get; set; }

        [Column("AVATAR")]
        public string Avatar { get; set; }

        [Column("GENDER")]
        public string Gender { get; set; }

        [Column("CREATED_BY")]
        public int? CreatedBy { get; set; }

        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }

        [Column("LAST_MODIFIED_BY")]
        public int? LastModifiedBy { get; set; }

        [Column("LAST_MODIFIED_AT")]
        public DateTime? LastModifiedAt { get; set; }

        [ForeignKey("Department")]
        [Column("DEPARTMENT_ID")]
        public int? DepartmentId { get; set; }

        public Department Department { get; set; } // Navigation property to Department entity
    }
}
