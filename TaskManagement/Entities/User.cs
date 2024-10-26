using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Entities
{
    [Table("Tbl_Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public DateTime? EmailVerifiedAt { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        [MaxLength(255)]
        public string RememberToken { get; set; }

        public DateTime? Birthday { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [MaxLength(255)]
        public string Avatar { get; set; }

        public string Gender { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedAt { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }

        // Navigation property
        //public virtual Department Department { get; set; }
    }
}
