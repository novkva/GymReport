using GymReport.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymReport.DAL.Contexts
{
    public class DbContextBase : DbContext
    {
        public DbContextBase(DbContextOptions<DbContextBase> options):
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Workout> Workouts { get; set; }
    }
}
