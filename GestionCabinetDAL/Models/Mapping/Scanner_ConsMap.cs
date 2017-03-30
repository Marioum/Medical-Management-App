using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class Scanner_ConsMap : EntityTypeConfiguration<Scanner_Cons>
    {
        public Scanner_ConsMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Scan_Cons);

            // Properties
            // Table & Column Mappings
            this.ToTable("Scanner_Cons");
            this.Property(t => t.id_Scan_Cons).HasColumnName("id_Scan_Cons");
            this.Property(t => t.numCons).HasColumnName("numCons");
            this.Property(t => t.id_scanner).HasColumnName("id_scanner");

            // Relationships
            this.HasRequired(t => t.Consultation)
                .WithMany(t => t.Scanner_Cons)
                .HasForeignKey(d => d.numCons);
            this.HasRequired(t => t.Scanner)
                .WithMany(t => t.Scanner_Cons)
                .HasForeignKey(d => d.id_scanner);

        }
    }
}
