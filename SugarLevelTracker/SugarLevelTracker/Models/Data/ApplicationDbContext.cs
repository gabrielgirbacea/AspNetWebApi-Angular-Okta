using System.Data.Entity;

namespace SugarLevelTracker.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("SugarLevelTrackerConnectionString")
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<SugarLevel> SugarLevels { get; set; }
    }
}
