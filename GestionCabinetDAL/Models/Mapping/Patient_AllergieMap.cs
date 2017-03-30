using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class Patient_AllergieMap : EntityTypeConfiguration<Patient_Allergie>
    {
        public Patient_AllergieMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Pat_All);

            // Properties
            // Table & Column Mappings
            this.ToTable("Patient_Allergie");
            this.Property(t => t.id_Pat_All).HasColumnName("id_Pat_All");
            this.Property(t => t.numCin).HasColumnName("numCin");
            this.Property(t => t.id_All).HasColumnName("id_All");

            // Relationships
            this.HasRequired(t => t.Allergie)
                .WithMany(t => t.Patient_Allergie)
                .HasForeignKey(d => d.id_All);
            this.HasRequired(t => t.Patient)
                .WithMany(t => t.Patient_Allergie)
                .HasForeignKey(d => d.numCin);

        }
    }
}
