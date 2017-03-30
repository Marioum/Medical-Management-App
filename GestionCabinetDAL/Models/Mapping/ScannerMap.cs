using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class ScannerMap : EntityTypeConfiguration<Scanner>
    {
        public ScannerMap()
        {
            // Primary Key
            this.HasKey(t => t.id_scanner);

            // Properties
            this.Property(t => t.decripScanner)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Scanner");
            this.Property(t => t.id_scanner).HasColumnName("id_scanner");
            this.Property(t => t.decripScanner).HasColumnName("decripScanner");
        }
    }
}
