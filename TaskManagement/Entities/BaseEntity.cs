using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Entities
{
    [Serializable]
    public class BaseEntity<T>
    {
        [Key]
        [Column("ID")]
        public virtual T Id { get; set; }
    }
}
