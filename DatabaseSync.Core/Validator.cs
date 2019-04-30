using Microsoft.EntityFrameworkCore;

namespace DatabaseSync.Core
{
    public static class Validator
    {
        public static bool ValidateLocalConnectionString(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlite(connectionString);

            return ValidateConnectionString(optionsBuilder.Options);
        }

        public static bool ValidateRemoteConnectionString(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer(connectionString);

            return ValidateConnectionString(optionsBuilder.Options);
        }

        private static bool ValidateConnectionString(DbContextOptions<Context> options)
        {
            using (var context = new Context(options))
            {
                try
                {
                    return context.Database.CanConnect();
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
