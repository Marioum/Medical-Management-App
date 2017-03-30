using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class Radio_ConsMap : EntityTypeConfiguration<Radio_Cons>
    {
        public Radio_ConsMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Radio_Cons);

            // Properties
            // Table & Column Mappings
            this.ToTable("Radio_Cons");
            this.Property(t => t.id_Radio_Cons).HasColumnName("id_Radio_Cons");
            this.Property(t => t.id_radio).HasColumnName("id_radio");
            this.Property(t => t.numCons).HasColumnName("numCons");

            // Relationships
            this.HasRequired(t => t.Consultation)
                .WithMany(t => t.Radio_Cons)
                .HasForeignKey(d => d.numCons);
            this.HasRequired(t => t.Radio)
                .WithMany(t => t.Radio_Cons)
                .HasForeignKey(d => d.id_radio);

        }
    }
}
