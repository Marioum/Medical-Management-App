using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class IntervChirugicaleMap : EntityTypeConfiguration<IntervChirugicale>
    {
        public IntervChirugicaleMap()
        {
            // Primary Key
            this.HasKey(t => t.id_intChirurgie);

            // Properties
            this.Property(t => t.descripChirurgie)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("IntervChirugicale");
            this.Property(t => t.id_intChirurgie).HasColumnName("id_intChirurgie");
            this.Property(t => t.descripChirurgie).HasColumnName("descripChirurgie");
        }
    }
}
