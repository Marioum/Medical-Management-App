using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class ReeducationMap : EntityTypeConfiguration<Reeducation>
    {
        public ReeducationMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Ree);

            // Properties
            this.Property(t => t.descripReeducation)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Reeducation");
            this.Property(t => t.id_Ree).HasColumnName("id_Ree");
            this.Property(t => t.descripReeducation).HasColumnName("descripReeducation");
        }
    }
}
