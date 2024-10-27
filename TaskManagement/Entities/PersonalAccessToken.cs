using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_PERSONAL_ACCESS_TOKENS")]
    public class PersonalAccessToken
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TOKENABLE")]
        public string Tokenable { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("TOKEN")]
        public string Token { get; set; }

        [Column("ABILITIES")]
        public string Abilities { get; set; }

        [Column("LAST_USED_AT")]
        public DateTime? LastUsedAt { get; set; }

        [Column("EXPIRES_AT")]
        public DateTime? ExpiresAt { get; set; }

        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }
    }
}
