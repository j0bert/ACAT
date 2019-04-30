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
        public static List<TeacherModel> LoadTeacher(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<TeacherModel>("select * from Teacher where user_ID = '" + username + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTeacher(TeacherModel teacher)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into Teacher (teacher_ID, user_ID, firstName, lastName, email) " +
                    "values (@teacher_ID, @user_ID, @firstName, @lastName, @email)", teacher);
            }
        }

        public static List<MissionObjectiveModel> LoadMissionObjective(string CRN)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<MissionObjectiveModel>("select * from MissionObjective where CRN = '" + CRN + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveMissionObjective(MissionObjectiveModel missionObjective)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into MissionObjective(objective_ID, description_MO, CRN) values (@objective_ID, @description_MO, @CRN)", missionObjective);
            }
        }

        public static void DeleteMissionObjective(string CRN)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("delete from MissionObjective where CRN = '" + CRN + "'", new DynamicParameters());
            }
        }

        public static List<AssessmentModel> LoadAssessment(string CRN)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<AssessmentModel>("select * from Assessment where CRN = '" + CRN + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveAssessment(AssessmentModel assessment)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into Assessment(assessment_ID, title, high, mid, low, average, standardDeviation, CRN) " +
                    "values (@assessment_ID, @title, @high, @mid, @low, @average, @standardDeviation, @CRN)", assessment);
            }
        }

        public static void DeleteAssessment(string CRN)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("delete from Assessment where CRN = '" + CRN + "'", new DynamicParameters());
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

        public static List<LearningOutcomeModel> LoadLearningOutcome(string CRN)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<LearningOutcomeModel>("select * from LearningOutcome where CRN = '" + CRN + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveLearningOutcome(LearningOutcomeModel learningOutcome)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into LearningOutcome(outcome_ID, description_LO, CRN) " +
                    "values (@outcome_ID, @description_LO, @CRN)", learningOutcome);
            }
        }

        public static void DeleteLearningOutcome(string CRN)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("delete from LearningOutcome where CRN = '" + CRN + "'", new DynamicParameters());
            }
        }

        public static List<ClassModel> LoadClass(int teacher_ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<ClassModel>("select * from Classes where teacher_ID = '" + teacher_ID + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ClassModel> LoadClassViaCRN(string CRN)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<ClassModel>("select * from Classes where CRN = '" + CRN + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveClass(ClassModel classes)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("insert into Classes(CRN, className, semester, year, comments, teacher_ID) " +
                    "values (@CRN, @className, @semester, @year, @comments, @teacher_ID)", classes);
            }
        }

        public static void DeleteClass(string CRN)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("delete from Classes where CRN = '" + CRN + "'", new DynamicParameters());
            }
        }

        public static void updateComments(string CRN, string comments)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                cnn.Execute("update Classes set comments = '" +comments+ "' where CRN = '" + CRN + "'", new DynamicParameters());
            }
        }

        public static List<LoginModel> passwordFetch(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectingString()))
            {
                var output = cnn.Query<LoginModel>("select * from Login where userName = '" + username + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectingString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

