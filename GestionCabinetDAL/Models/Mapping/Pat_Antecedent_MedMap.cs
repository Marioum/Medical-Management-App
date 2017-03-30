using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class Pat_Antecedent_MedMap : EntityTypeConfiguration<Pat_Antecedent_Med>
    {
        public Pat_Antecedent_MedMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Pat_AM);

            // Properties
            // Table & Column Mappings
            this.ToTable("Pat_Antecedent_Med");
            this.Property(t => t.id_Pat_AM).HasColumnName("id_Pat_AM");
            this.Property(t => t.numCin).HasColumnName("numCin");
            this.Property(t => t.id_Ant_Med).HasColumnName("id_Ant_Med");

            // Relationships
            this.HasRequired(t => t.AntecedentMedical)
                .WithMany(t => t.Pat_Antecedent_Med)
                .HasForeignKey(d => d.id_Ant_Med);
            this.HasRequired(t => t.Patient)
                .WithMany(t => t.Pat_Antecedent_Med)
                .HasForeignKey(d => d.numCin);

        }
    }
}
