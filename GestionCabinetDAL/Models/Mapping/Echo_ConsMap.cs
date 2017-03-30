using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class Echo_ConsMap : EntityTypeConfiguration<Echo_Cons>
    {
        public Echo_ConsMap()
        {
            // Primary Key
            this.HasKey(t => t.id_echo_cons);

            // Properties
            // Table & Column Mappings
            this.ToTable("Echo_Cons");
            this.Property(t => t.id_echo_cons).HasColumnName("id_echo_cons");
            this.Property(t => t.id_echo).HasColumnName("id_echo");
            this.Property(t => t.numCons).HasColumnName("numCons");

            // Relationships
            this.HasRequired(t => t.Consultation)
                .WithMany(t => t.Echo_Cons)
                .HasForeignKey(d => d.numCons);
            this.HasRequired(t => t.Echographie)
                .WithMany(t => t.Echo_Cons)
                .HasForeignKey(d => d.id_echo);

        }
    }
}
