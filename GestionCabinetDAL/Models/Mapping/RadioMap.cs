using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class RadioMap : EntityTypeConfiguration<Radio>
    {
        public RadioMap()
        {
            // Primary Key
            this.HasKey(t => t.id_radio);

            // Properties
            this.Property(t => t.descripRadio)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Radio");
            this.Property(t => t.id_radio).HasColumnName("id_radio");
            this.Property(t => t.descripRadio).HasColumnName("descripRadio");
        }
    }
}
