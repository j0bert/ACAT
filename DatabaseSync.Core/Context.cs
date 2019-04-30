using DatabaseSync.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSync.Core
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
               .UseLazyLoadingProxies();

        public DbSet<Abet> Abets { get; set; }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Assessment> Assessments { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<LearningOutcome> LearningOutcomes { get; set; }

        public DbSet<MissionObjective> MissionObjectives { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
