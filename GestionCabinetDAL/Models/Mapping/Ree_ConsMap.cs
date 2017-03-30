using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class Ree_ConsMap : EntityTypeConfiguration<Ree_Cons>
    {
        public Ree_ConsMap()
        {
            // Primary Key
            this.HasKey(t => t.id_ree_cons);

            // Properties
            // Table & Column Mappings
            this.ToTable("Ree_Cons");
            this.Property(t => t.id_ree_cons).HasColumnName("id_ree_cons");
            this.Property(t => t.numCons).HasColumnName("numCons");
            this.Property(t => t.id_Ree).HasColumnName("id_Ree");

            // Relationships
            this.HasRequired(t => t.Consultation)
                .WithMany(t => t.Ree_Cons)
                .HasForeignKey(d => d.numCons);
            this.HasRequired(t => t.Reeducation)
                .WithMany(t => t.Ree_Cons)
                .HasForeignKey(d => d.id_Ree);

        }
    }
}
