using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class Med_ConsMap : EntityTypeConfiguration<Med_Cons>
    {
        public Med_ConsMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Med_Cons);

            // Properties
            // Table & Column Mappings
            this.ToTable("Med_Cons");
            this.Property(t => t.id_Med_Cons).HasColumnName("id_Med_Cons");
            this.Property(t => t.duree_traitement).HasColumnName("duree_traitement");
            this.Property(t => t.numCons).HasColumnName("numCons");
            this.Property(t => t.id_Med).HasColumnName("id_Med");

            // Relationships
            this.HasRequired(t => t.Consultation)
                .WithMany(t => t.Med_Cons)
                .HasForeignKey(d => d.numCons);
            this.HasRequired(t => t.Medicament)
                .WithMany(t => t.Med_Cons)
                .HasForeignKey(d => d.id_Med);

        }
    }
}
