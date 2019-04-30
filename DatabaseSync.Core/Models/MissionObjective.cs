using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSync.Core.Models
{
    [Table("MissionObjective")]
    public class MissionObjective
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("objective_number")]
        public int MissionObjectiveId { get; set; }

        [Column("description_MO")]
        public string Description { get; set; }

        [Column("crn")]
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
