using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class IRMMap : EntityTypeConfiguration<IRM>
    {
        public IRMMap()
        {
            // Primary Key
            this.HasKey(t => t.id_IRM);

            // Properties
            this.Property(t => t.descripIRM)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("IRM");
            this.Property(t => t.id_IRM).HasColumnName("id_IRM");
            this.Property(t => t.descripIRM).HasColumnName("descripIRM");
        }
    }
}
