using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSync.Core.Models
{
    [Table("LearningOutcome")]
    public class LearningOutcome
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("outcome_ID")]
        public int LearningOutcomeId { get; set; }

        [Column("description_LO")]
        public string Description { get; set; }

        [Column("crn")]
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
