using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class MedicamentMap : EntityTypeConfiguration<Medicament>
    {
        public MedicamentMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Med);

            // Properties
            this.Property(t => t.nom)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Medicaments");
            this.Property(t => t.id_Med).HasColumnName("id_Med");
            this.Property(t => t.nom).HasColumnName("nom");
        }
    }
}
