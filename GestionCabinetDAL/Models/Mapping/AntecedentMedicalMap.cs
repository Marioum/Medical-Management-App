using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class AntecedentMedicalMap : EntityTypeConfiguration<AntecedentMedical>
    {
        public AntecedentMedicalMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Ant_Med);

            // Properties
            this.Property(t => t.nom_Maladie)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AntecedentMedical");
            this.Property(t => t.id_Ant_Med).HasColumnName("id_Ant_Med");
            this.Property(t => t.nom_Maladie).HasColumnName("nom_Maladie");
        }
    }
}
