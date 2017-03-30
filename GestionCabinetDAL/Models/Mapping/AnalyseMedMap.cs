using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class AnalyseMedMap : EntityTypeConfiguration<AnalyseMed>
    {
        public AnalyseMedMap()
        {
            // Primary Key
            this.HasKey(t => t.id_AnalyseMed);

            // Properties
            this.Property(t => t.descripAnalyseMed)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AnalyseMed");
            this.Property(t => t.id_AnalyseMed).HasColumnName("id_AnalyseMed");
            this.Property(t => t.descripAnalyseMed).HasColumnName("descripAnalyseMed");
        }
    }
}
