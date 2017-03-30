using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class InterChirur_ConsMap : EntityTypeConfiguration<InterChirur_Cons>
    {
        public InterChirur_ConsMap()
        {
            // Primary Key
            this.HasKey(t => t.id_ICh_Cons);

            // Properties
            // Table & Column Mappings
            this.ToTable("InterChirur_Cons");
            this.Property(t => t.id_ICh_Cons).HasColumnName("id_ICh_Cons");
            this.Property(t => t.numCons).HasColumnName("numCons");
            this.Property(t => t.id_intChirurgie).HasColumnName("id_intChirurgie");

            // Relationships
            this.HasRequired(t => t.Consultation)
                .WithMany(t => t.InterChirur_Cons)
                .HasForeignKey(d => d.numCons);
            this.HasRequired(t => t.IntervChirugicale)
                .WithMany(t => t.InterChirur_Cons)
                .HasForeignKey(d => d.id_intChirurgie);

        }
    }
}
