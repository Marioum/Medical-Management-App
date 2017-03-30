using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class AnalyseMed_ConsMap : EntityTypeConfiguration<AnalyseMed_Cons>
    {
        public AnalyseMed_ConsMap()
        {
            // Primary Key
            this.HasKey(t => t.id_AnMed_Cons);

            // Properties
            // Table & Column Mappings
            this.ToTable("AnalyseMed_Cons");
            this.Property(t => t.id_AnMed_Cons).HasColumnName("id_AnMed_Cons");
            this.Property(t => t.id_AnalyseMed).HasColumnName("id_AnalyseMed");
            this.Property(t => t.numCons).HasColumnName("numCons");

            // Relationships
            this.HasRequired(t => t.AnalyseMed)
                .WithMany(t => t.AnalyseMed_Cons)
                .HasForeignKey(d => d.id_AnalyseMed);
            this.HasRequired(t => t.Consultation)
                .WithMany(t => t.AnalyseMed_Cons)
                .HasForeignKey(d => d.numCons);

        }
    }
}
