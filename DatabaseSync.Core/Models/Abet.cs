using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSync.Core.Models
{
    [Table("ABET")]
    public class Abet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("abet_ID")]
        public int AbetId { get; set; }

        [Column("description_ABET")]
        public string Description { get; set; }
    }
}
