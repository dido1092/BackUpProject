using BackUpProject.BackUpProjectDataCommon;
using BackUpProject.BackUpProjectDataModels;
using Microsoft.EntityFrameworkCore;

namespace BackUpProject.BackUpProjectData
{
    public class BackUpProjectContext : DbContext
    {
        public BackUpProjectContext()
        {
        }

        public DbSet<PathToBackUp> PathToBackUps { get; set; }

        public DbSet<BackUpState> BackUpStates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
                optionsBuilder.EnableSensitiveDataLogging();
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
