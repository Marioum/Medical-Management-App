using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class AllergieMap : EntityTypeConfiguration<Allergie>
    {
        public AllergieMap()
        {
            // Primary Key
            this.HasKey(t => t.id_All);

            // Properties
            this.Property(t => t.nomAllergie)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Allergie");
            this.Property(t => t.id_All).HasColumnName("id_All");
            this.Property(t => t.nomAllergie).HasColumnName("nomAllergie");
        }
    }
}
