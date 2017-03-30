using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class ConsultationMap : EntityTypeConfiguration<Consultation>
    {
        public ConsultationMap()
        {
            // Primary Key
            this.HasKey(t => t.numCons);

            // Properties
            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Consultation");
            this.Property(t => t.numCons).HasColumnName("numCons");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.numCin).HasColumnName("numCin");

            // Relationships
            this.HasRequired(t => t.Patient)
                .WithMany(t => t.Consultations)
                .HasForeignKey(d => d.numCin);

        }
    }
}
