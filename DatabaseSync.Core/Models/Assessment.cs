using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSync.Core.Models
{
    [Table("Assessment")]
    public class Assessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("assessment_ID")]
        public int AssessmentId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("high")]
        public decimal High { get; set; }

        [Column("low")]
        public decimal Low { get; set; }

        [Column("mid")]
        public decimal Mid { get; set; }

        [Column("standardDeviation")]
        public decimal StandardDeviation { get; set; }

        [Column("average")]
        public decimal Average { get; set; }

        [Column("crn")]
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
