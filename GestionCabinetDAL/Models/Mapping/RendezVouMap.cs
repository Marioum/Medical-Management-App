using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class RendezVouMap : EntityTypeConfiguration<RendezVou>
    {
        public RendezVouMap()
        {
            // Primary Key
            this.HasKey(t => t.numRDV);

            // Properties
            // Table & Column Mappings
            this.ToTable("RendezVous");
            this.Property(t => t.numRDV).HasColumnName("numRDV");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.heue).HasColumnName("heue");
            this.Property(t => t.numCin).HasColumnName("numCin");

            // Relationships
            this.HasRequired(t => t.Patient)
                .WithMany(t => t.RendezVous)
                .HasForeignKey(d => d.numCin);

        }
    }
}
