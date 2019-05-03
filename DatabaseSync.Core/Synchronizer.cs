using DatabaseSync.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseSync.Core
{
    public static class Synchronizer
    {
        public async static Task SyncLocalToRemoteAsync(string localConnectionString, string remoteConnectionString)
        {
            var abets = new List<Abet>();
            var logins = new List<Login>();
            var assessments = new List<Assessment>();
            var classes = new List<Class>();
            var learningOutcomes = new List<LearningOutcome>();
            var missionObjectives = new List<MissionObjective>();
            var teachers = new List<Teacher>();

            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlite(localConnectionString);

            using (var localContext = new Context(optionsBuilder.Options))
            {
                abets = await localContext.Abets.ToListAsync();
                logins = await localContext.Logins.ToListAsync();
                assessments = await localContext.Assessments.ToListAsync();
                classes = await localContext.Classes.ToListAsync();
                learningOutcomes = await localContext.LearningOutcomes.ToListAsync();
                missionObjectives = await localContext.MissionObjectives.ToListAsync();
                teachers = await localContext.Teachers.ToListAsync();
            }

            var remoteOptionsBuilder = new DbContextOptionsBuilder<Context>();
            remoteOptionsBuilder.UseSqlServer(remoteConnectionString);

            using (var remoteContext = new Context(remoteOptionsBuilder.Options))
            {
                using (var transaction = remoteContext.Database.BeginTransaction())
                {
                    SyncRemoteAbets(remoteContext, abets);
                    await remoteContext.SaveChangesAsync();

                    SyncRemoteLogins(remoteContext, logins);
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.LOGIN ON");
                    await remoteContext.SaveChangesAsync();
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.LOGIN OFF");

                    SyncRemoteTeachers(remoteContext, teachers);
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.TEACHER ON");
                    await remoteContext.SaveChangesAsync();
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.TEACHER OFF");

                    SyncRemoteClasses(remoteContext, classes);
                    await remoteContext.SaveChangesAsync();

                    SyncRemoteAssessments(remoteContext, assessments);
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.ASSESSMENT ON");
                    await remoteContext.SaveChangesAsync();
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.ASSESSMENT OFF");

                    SyncRemoteMissionObjectives(remoteContext, missionObjectives);
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.MISSIONOBJECTIVE ON");
                    await remoteContext.SaveChangesAsync();
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.MISSIONOBJECTIVE OFF");

                    SyncRemoteLearningOutcomes(remoteContext, learningOutcomes);
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.LEARNINGOUTCOME ON");
                    await remoteContext.SaveChangesAsync();
                    remoteContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.LEARNINGOUTCOME OFF");

                    await remoteContext.SaveChangesAsync();

                    transaction.Commit();
                }
            }
        }

        public async static Task SyncRemoteToLocalAsync(string localConnectionString, string remoteConnectionString)
        {
            var abets = new List<Abet>();
            var logins = new List<Login>();
            var assessments = new List<Assessment>();
            var classes = new List<Class>();
            var learningOutcomes = new List<LearningOutcome>();
            var missionObjectives = new List<MissionObjective>();
            var teachers = new List<Teacher>();

            var remoteOptionsBuilder = new DbContextOptionsBuilder<Context>();
            remoteOptionsBuilder.UseSqlServer(remoteConnectionString);

            using (var remoteContext = new Context(remoteOptionsBuilder.Options))
            {
                abets = await remoteContext.Abets.ToListAsync();
                logins = await remoteContext.Logins.ToListAsync();
                assessments = await remoteContext.Assessments.ToListAsync();
                classes = await remoteContext.Classes.ToListAsync();
                learningOutcomes = await remoteContext.LearningOutcomes.ToListAsync();
                missionObjectives = await remoteContext.MissionObjectives.ToListAsync();
                teachers = await remoteContext.Teachers.ToListAsync();
            }

            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlite(localConnectionString);

            using (var localContext = new Context(optionsBuilder.Options))
            {
                using (var transaction = localContext.Database.BeginTransaction())
                {
                    SyncLocalAbets(localContext, abets);
                    await localContext.SaveChangesAsync();

                    SyncLocalLogins(localContext, logins);
                    await localContext.SaveChangesAsync();

                    SyncLocalTeachers(localContext, teachers);
                    await localContext.SaveChangesAsync();

                    SyncLocalClasses(localContext, classes);
                    await localContext.SaveChangesAsync();

                    SyncLocalAssessments(localContext, assessments);
                    await localContext.SaveChangesAsync();

                    SyncLocalLearningOutcomes(localContext, learningOutcomes);
                    await localContext.SaveChangesAsync();

                    SyncLocalMissionObjectives(localContext, missionObjectives);
                    await localContext.SaveChangesAsync();

                    await localContext.SaveChangesAsync();

                    transaction.Commit();
                }
            }
        }

        #region Remote sync
        private static void SyncRemoteAbets(Context remoteContext, List<Abet> localRecords)
        {
            var localIds = localRecords.Select(a => a.AbetId).ToList();

            var existingIds = remoteContext.Abets
                .Where(a => localIds.Contains(a.AbetId))
                .Select(a => a.AbetId)
                .ToList();

            foreach (var localRecord in localRecords)
            {
                if (existingIds.Contains(localRecord.AbetId))
                {
                    var currentRecord = remoteContext.Abets.First(r => r.AbetId == localRecord.AbetId);

                    remoteContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    remoteContext.Abets.Add(localRecord);
                }
            }
        }

        private static void SyncRemoteLogins(Context remoteContext, List<Login> localRecords)
        {
            var localIds = localRecords.Select(a => a.UserId).ToList();

            var existingIds = remoteContext.Logins
                .Where(a => localIds.Contains(a.UserId))
                .Select(a => a.UserId)
                .ToList();

            foreach (var localRecord in localRecords)
            {
                if (existingIds.Contains(localRecord.UserId))
                {
                    var currentRecord = remoteContext.Logins.First(r => r.UserId == localRecord.UserId);

                    remoteContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    remoteContext.Logins.Add(localRecord);
                }
            }
        }

        private static void SyncRemoteAssessments(Context remoteContext, List<Assessment> localRecords)
        {
            var localIds = localRecords.Select(a => a.AssessmentId).ToList();

            var existingIds = remoteContext.Assessments
                .Where(a => localIds.Contains(a.AssessmentId))
                .Select(a => a.AssessmentId)
                .ToList();

            foreach (var localRecord in localRecords)
            {
                if (existingIds.Contains(localRecord.AssessmentId))
                {
                    var currentRecord = remoteContext.Assessments.First(r => r.AssessmentId == localRecord.AssessmentId);

                    remoteContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    remoteContext.Assessments.Add(localRecord);
                }
            }
        }

        private static void SyncRemoteClasses(Context remoteContext, List<Class> localRecords)
        {
            var localIds = localRecords.Select(a => a.ClassId).ToList();

            var existingIds = remoteContext.Classes
                .Where(a => localIds.Contains(a.ClassId))
                .Select(a => a.ClassId)
                .ToList();

            foreach (var localRecord in localRecords)
            {
                if (existingIds.Contains(localRecord.ClassId))
                {
                    var currentRecord = remoteContext.Classes.First(r => r.ClassId == localRecord.ClassId);

                    remoteContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    remoteContext.Classes.Add(localRecord);
                }
            }
        }

        private static void SyncRemoteLearningOutcomes(Context remoteContext, List<LearningOutcome> localRecords)
        {
            var localIds = localRecords.Select(a => a.LearningOutcomeId).ToList();

            var existingIds = remoteContext.LearningOutcomes
                .Where(a => localIds.Contains(a.LearningOutcomeId))
                .Select(a => a.LearningOutcomeId)
                .ToList();

            foreach (var localRecord in localRecords)
            {
                if (existingIds.Contains(localRecord.LearningOutcomeId))
                {
                    var currentRecord = remoteContext.LearningOutcomes.First(r => r.LearningOutcomeId == localRecord.LearningOutcomeId);

                    remoteContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    remoteContext.LearningOutcomes.Add(localRecord);
                }
            }
        }

        private static void SyncRemoteMissionObjectives(Context remoteContext, List<MissionObjective> localRecords)
        {
            var localIds = localRecords.Select(a => a.MissionObjectiveId).ToList();

            var existingIds = remoteContext.MissionObjectives
                .Where(a => localIds.Contains(a.MissionObjectiveId))
                .Select(a => a.MissionObjectiveId)
                .ToList();

            foreach (var localRecord in localRecords)
            {
                if (existingIds.Contains(localRecord.MissionObjectiveId))
                {
                    var currentRecord = remoteContext.MissionObjectives.First(r => r.MissionObjectiveId == localRecord.MissionObjectiveId);

                    remoteContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    remoteContext.MissionObjectives.Add(localRecord);
                }
            }
        }

        private static void SyncRemoteTeachers(Context remoteContext, List<Teacher> localRecords)
        {
            var localIds = localRecords.Select(a => a.TeacherId).ToList();

            var existingIds = remoteContext.Teachers
                .Where(a => localIds.Contains(a.TeacherId))
                .Select(a => a.TeacherId)
                .ToList();

            foreach (var localRecord in localRecords)
            {
                if (existingIds.Contains(localRecord.TeacherId))
                {
                    var currentRecord = remoteContext.Teachers.First(r => r.TeacherId == localRecord.TeacherId);

                    remoteContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    remoteContext.Teachers.Add(localRecord);
                }
            }
        }
        #endregion

        #region Local sync
        private static void SyncLocalAbets(Context localContext, List<Abet> remoteRecords)
        {
            var localIds = remoteRecords.Select(a => a.AbetId).ToList();

            var existingIds = localContext.Abets
                .Where(a => localIds.Contains(a.AbetId))
                .Select(a => a.AbetId)
                .ToList();

            foreach (var localRecord in remoteRecords)
            {
                if (existingIds.Contains(localRecord.AbetId))
                {
                    var currentRecord = localContext.Abets.First(r => r.AbetId == localRecord.AbetId);

                    localContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    localContext.Abets.Add(localRecord);
                }
            }
        }

        private static void SyncLocalLogins(Context localContext, List<Login> remoteRecords)
        {
            var localIds = remoteRecords.Select(a => a.UserId).ToList();

            var existingIds = localContext.Logins
                .Where(a => localIds.Contains(a.UserId))
                .Select(a => a.UserId)
                .ToList();

            foreach (var localRecord in remoteRecords)
            {
                if (existingIds.Contains(localRecord.UserId))
                {
                    var currentRecord = localContext.Logins.First(r => r.UserId == localRecord.UserId);

                    localContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    localContext.Logins.Add(localRecord);
                }
            }
        }

        private static void SyncLocalAssessments(Context localContext, List<Assessment> remoteRecords)
        {
            var localIds = remoteRecords.Select(a => a.AssessmentId).ToList();

            var existingIds = localContext.Assessments
                .Where(a => localIds.Contains(a.AssessmentId))
                .Select(a => a.AssessmentId)
                .ToList();

            foreach (var localRecord in remoteRecords)
            {
                if (existingIds.Contains(localRecord.AssessmentId))
                {
                    var currentRecord = localContext.Assessments.First(r => r.AssessmentId == localRecord.AssessmentId);

                    localContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    localContext.Assessments.Add(localRecord);
                }
            }
        }

        private static void SyncLocalClasses(Context localContext, List<Class> remoteRecords)
        {
            var localIds = remoteRecords.Select(a => a.ClassId).ToList();

            var existingIds = localContext.Classes
                .Where(a => localIds.Contains(a.ClassId))
                .Select(a => a.ClassId)
                .ToList();

            foreach (var localRecord in remoteRecords)
            {
                if (existingIds.Contains(localRecord.ClassId))
                {
                    var currentRecord = localContext.Classes.First(r => r.ClassId == localRecord.ClassId);

                    localContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    localContext.Classes.Add(localRecord);
                }
            }
        }

        private static void SyncLocalLearningOutcomes(Context localContext, List<LearningOutcome> remoteRecords)
        {
            var localIds = remoteRecords.Select(a => a.LearningOutcomeId).ToList();

            var existingIds = localContext.LearningOutcomes
                .Where(a => localIds.Contains(a.LearningOutcomeId))
                .Select(a => a.LearningOutcomeId)
                .ToList();

            foreach (var localRecord in remoteRecords)
            {
                if (existingIds.Contains(localRecord.LearningOutcomeId))
                {
                    var currentRecord = localContext.LearningOutcomes.First(r => r.LearningOutcomeId == localRecord.LearningOutcomeId);

                    localContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    localContext.LearningOutcomes.Add(localRecord);
                }
            }
        }

        private static void SyncLocalMissionObjectives(Context localContext, List<MissionObjective> remoteRecords)
        {
            var localIds = remoteRecords.Select(a => a.MissionObjectiveId).ToList();

            var existingIds = localContext.MissionObjectives
                .Where(a => localIds.Contains(a.MissionObjectiveId))
                .Select(a => a.MissionObjectiveId)
                .ToList();

            foreach (var localRecord in remoteRecords)
            {
                if (existingIds.Contains(localRecord.MissionObjectiveId))
                {
                    var currentRecord = localContext.MissionObjectives.First(r => r.MissionObjectiveId == localRecord.MissionObjectiveId);

                    localContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    localContext.MissionObjectives.Add(localRecord);
                }
            }
        }

        private static void SyncLocalTeachers(Context localContext, List<Teacher> remoteRecords)
        {
            var localIds = remoteRecords.Select(a => a.TeacherId).ToList();

            var existingIds = localContext.Teachers
                .Where(a => localIds.Contains(a.TeacherId))
                .Select(a => a.TeacherId)
                .ToList();

            foreach (var localRecord in remoteRecords)
            {
                if (existingIds.Contains(localRecord.TeacherId))
                {
                    var currentRecord = localContext.Teachers.First(r => r.TeacherId == localRecord.TeacherId);

                    localContext.Entry(currentRecord).CurrentValues.SetValues(localRecord);
                }
                else
                {
                    localContext.Teachers.Add(localRecord);
                }
            }
        }
        #endregion
    }
}
