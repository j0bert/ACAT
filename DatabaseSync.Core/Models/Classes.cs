using DatabaseSync.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSync.Core.Models
{
    [Table("Classes")]
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("crn")]
        public int ClassId { get; set; }

        public string ClassName { get; set; }

        public string Semester { get; set; }

        public int Year { get; set; }

        public string Comments { get; set; }

        [Column("teacher_id")]
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
