using Microsoft.EntityFrameworkCore;

namespace TheroToHeroCRUDInVSCode
{
    internal class NajotTalimDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<University> Universities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.CONNECTION_STRING);
        }

    }
}