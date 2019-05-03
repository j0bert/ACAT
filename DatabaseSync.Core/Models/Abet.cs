using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSync.Core.Models
{
    [Table("ABET")]
    public class Abet
    {
        [Key]
        [Column("abet_ID")]
        public string AbetId { get; set; }

        [Column("description_ABET")]
        public string Description { get; set; }
    }
}
