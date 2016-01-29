using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Pro_ATM.Models.Mapping;

namespace Pro_ATM.Models
{
    public partial class ProiectBazeContext : DbContext
    {
        static ProiectBazeContext()
        {
            Database.SetInitializer<ProiectBazeContext>(null);
        }

        public ProiectBazeContext()
            : base("Name=ProiectBazeContext")
        {
        }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Grupe> Grupes { get; set; }
        public DbSet<LogInn> LogInns { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Prof_date> Prof_date { get; set; }
        public DbSet<Profesor> Profesors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdministratorMap());
            modelBuilder.Configurations.Add(new DisciplinaMap());
            modelBuilder.Configurations.Add(new GrupeMap());
            modelBuilder.Configurations.Add(new LogInnMap());
            modelBuilder.Configurations.Add(new NoteMap());
            modelBuilder.Configurations.Add(new Prof_dateMap());
            modelBuilder.Configurations.Add(new ProfesorMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
