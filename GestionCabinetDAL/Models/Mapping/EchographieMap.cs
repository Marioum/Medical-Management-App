using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class EchographieMap : EntityTypeConfiguration<Echographie>
    {
        public EchographieMap()
        {
            // Primary Key
            this.HasKey(t => t.id_echo);

            // Properties
            this.Property(t => t.descripEcho)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Echographie");
            this.Property(t => t.id_echo).HasColumnName("id_echo");
            this.Property(t => t.descripEcho).HasColumnName("descripEcho");
        }
    }
}
