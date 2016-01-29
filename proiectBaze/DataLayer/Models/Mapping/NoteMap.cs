using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class NoteMap : EntityTypeConfiguration<Note>
    {
        public NoteMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nota, t.nr_credite, t.id_disc, t.id_stud, t.id_prof, t.forma });

            // Properties
            this.Property(t => t.nota)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nr_credite)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_disc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_stud)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_prof)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.forma)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Note");
            this.Property(t => t.nota).HasColumnName("nota");
            this.Property(t => t.nr_credite).HasColumnName("nr credite");
            this.Property(t => t.id_disc).HasColumnName("id_disc");
            this.Property(t => t.id_stud).HasColumnName("id_stud");
            this.Property(t => t.id_prof).HasColumnName("id_prof");
            this.Property(t => t.forma).HasColumnName("forma");

            // Relationships
            this.HasRequired(t => t.Disciplina)
                .WithMany(t => t.Notes)
                .HasForeignKey(d => d.id_disc);
            this.HasRequired(t => t.Profesor)
                .WithMany(t => t.Notes)
                .HasForeignKey(d => d.id_prof);
            this.HasRequired(t => t.Student)
                .WithMany(t => t.Notes)
                .HasForeignKey(d => d.id_stud);

        }
    }
}
