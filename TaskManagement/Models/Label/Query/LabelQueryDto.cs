using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Models.Label.Query
{
    public class LabelQueryDto
    {
        public int Id { get; set; }

        [Column("CODE")]
        public string Code { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("COLOR")]
        public string Color { get; set; }
    }
}
