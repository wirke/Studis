using Microsoft.EntityFrameworkCore;

namespace Studis.Server.Model
{
    public class SkolaContext : DbContext
    {
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Kredencijali> Kredencijali { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public SkolaContext(DbContextOptions options) : base(options){}
    }
}