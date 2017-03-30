using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class IRM_ConsMap : EntityTypeConfiguration<IRM_Cons>
    {
        public IRM_ConsMap()
        {
            // Primary Key
            this.HasKey(t => t.id_IRM_Cons);

            // Properties
            // Table & Column Mappings
            this.ToTable("IRM_Cons");
            this.Property(t => t.id_IRM_Cons).HasColumnName("id_IRM_Cons");
            this.Property(t => t.numCons).HasColumnName("numCons");
            this.Property(t => t.id_IRM).HasColumnName("id_IRM");

            // Relationships
            this.HasRequired(t => t.Consultation)
                .WithMany(t => t.IRM_Cons)
                .HasForeignKey(d => d.numCons);
            this.HasRequired(t => t.IRM)
                .WithMany(t => t.IRM_Cons)
                .HasForeignKey(d => d.id_IRM);

        }
    }
}
