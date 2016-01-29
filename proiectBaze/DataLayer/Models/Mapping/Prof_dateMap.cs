using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class Prof_dateMap : EntityTypeConfiguration<Prof_date>
    {
        public Prof_dateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id_prof, t.id_grupa, t.id_disc });

            // Properties
            this.Property(t => t.id_prof)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_grupa)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_disc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Prof_date");
            this.Property(t => t.id_prof).HasColumnName("id_prof");
            this.Property(t => t.id_grupa).HasColumnName("id_grupa");
            this.Property(t => t.id_disc).HasColumnName("id_disc");

            // Relationships
            this.HasRequired(t => t.Disciplina)
                .WithMany(t => t.Prof_date)
                .HasForeignKey(d => d.id_disc);
            this.HasRequired(t => t.Grupe)
                .WithMany(t => t.Prof_date)
                .HasForeignKey(d => d.id_grupa);
            this.HasRequired(t => t.Profesor)
                .WithMany(t => t.Prof_date)
                .HasForeignKey(d => d.id_prof);

        }
    }
}
