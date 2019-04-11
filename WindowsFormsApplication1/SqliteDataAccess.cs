using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SqliteDataAccess
    {
        public static List<TeacherModel> LoadTeacher()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<TeacherModel>("select * from Teacher", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTeacher(TeacherModel teacher)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into Teacher (teacherID, teacherUserName, teacherPassword, isAdmin, teachersName) " +
                    "values (@teacherID, @teacherUserName, @teacherPassword, @isAdmin, @teachersName)", teacher);
            }
        }

        public static List<AdminModel> LoadAdmin()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<AdminModel>("select * from Admin", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveAdmin(AdminModel admin)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into Admin(adminID, teacherID) values (@adminID, @teacherID)", admin);
            }
        }

        public static List<MissionObjectiveModel> LoadMissionObjective()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<MissionObjectiveModel>("select * from MissionObjective", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveMissionObjectiveModel(MissionObjectiveModel missionObjective)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into MissionObjective(MissionObjectiveID, missionObjective) values (@MissionObjectiveID, @missionObjective)", missionObjective);
            }
        }

        public static List<AssessmentModel> LoadAssessment()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<AssessmentModel>("select * from Assessment", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveAssessment(AssessmentModel assessment)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into Assessment(assessmentID, assessmentName, average, standardDeviation) " +
                    "values (@assessmentID, @assessmentName, @average, @standardDeviation)", assessment);
            }
        }

        public static List<ABETModel> LoadABET()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<ABETModel>("select * from ABET", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveABET(ABETModel ABET)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into ABET(abetID, abetLearningOutcomes) values (@abetID, @abetLearningOutcomes)", ABET);
            }
        }

        public static List<LearningOutcomeModel> LoadLearningOutcome()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<LearningOutcomeModel>("select * from LearningOutcome", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveLearningOutcome(LearningOutcomeModel learningOutcome)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into LearningOutcome(OutcomeID, outcome, MissionObjectiveID, AssessmentID, AbetID) " +
                    "values (@OutcomeID, @outcome, @MissionObjectiveID, @AssessmentID, @AbetID)", learningOutcome);
            }
        }

        public static List<CourseModel> LoadCourse()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<CourseModel>("select * from Course", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveCourse(CourseModel course)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into Course(courseID, teacherID, courseName, semester, year, comments, OutcomeID, MissionObjectiveID, AssessmentID, AbeTID) " +
                    "values (@courseID, @teacherID, @courseName, @semester, @year, @comments, @OutcomeID, @MissionObjectiveID, @AssessmentID, @AbeTID)", course);
            }
        }

        private static string LoadConnectingString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
