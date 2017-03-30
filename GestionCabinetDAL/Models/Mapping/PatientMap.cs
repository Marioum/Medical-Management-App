using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GestionCabinetDAL.Models.Mapping
{
    public class PatientMap : EntityTypeConfiguration<Patient>
    {
        public PatientMap()
        {
            // Primary Key
            this.HasKey(t => t.numCin);

            // Properties
            this.Property(t => t.numCin)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nom)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.prenom)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.sexe)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.etatCivil)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.profession)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Patient");
            this.Property(t => t.numCin).HasColumnName("numCin");
            this.Property(t => t.nom).HasColumnName("nom");
            this.Property(t => t.prenom).HasColumnName("prenom");
            this.Property(t => t.dateNaissance).HasColumnName("dateNaissance");
            this.Property(t => t.sexe).HasColumnName("sexe");
            this.Property(t => t.etatCivil).HasColumnName("etatCivil");
            this.Property(t => t.profession).HasColumnName("profession");
            this.Property(t => t.poids).HasColumnName("poids");
            this.Property(t => t.nbreEnfant).HasColumnName("nbreEnfant");
            this.Property(t => t.taille).HasColumnName("taille");
            this.Property(t => t.numCNSS_CNRPS).HasColumnName("numCNSS_CNRPS");
        }
    }
}
