using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSync.Core.Models
{
    [Table("LearningOutcomes")]
    public class LearningOutcome
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("outcome_number")]
        public int LearningOutcomeId { get; set; }

        [Column("description_LO")]
        public string Description { get; set; }

        [Column("missionObjectives")]
        public string MissionObjectives { get; set; }

        [Column("abetOutcomes")]
        public string AbetOutcomes { get; set; }

        [Column("crn")]
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
