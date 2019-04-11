using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CourseModel
    {
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public string courseName { get; set; }
        public string semester { get; set; }
        public int year { get; set; }
        public string comments { get; set; }
        public int OutcomeID { get; set; }
        public int MissionObjectiveID { get; set; }
        public int AssessmentID { get; set; }
        public int AbetID { get; set; }
    }
}
