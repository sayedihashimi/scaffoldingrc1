using Microsoft.Data.Entity;

namespace SampleWeb.Models
{
    public class StudentContext : DbContext
    {
        private static bool _created = false;

        public StudentContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}
