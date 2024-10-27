using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_PASSWORD_RESET_TOKENS")]
    public class PasswordResetToken
    {
        [Key]
        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("TOKEN")]
        public string Token { get; set; }

        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }
    }
}
