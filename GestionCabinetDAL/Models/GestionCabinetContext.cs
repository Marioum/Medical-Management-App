using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GestionCabinetDAL.Models.Mapping;

namespace GestionCabinetDAL.Models
{
    public partial class GestionCabinetContext : DbContext
    {
        static GestionCabinetContext()
        {
            Database.SetInitializer<GestionCabinetContext>(null);
        }

        public GestionCabinetContext()
            : base("Name=GestionCabinetContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Allergie> Allergies { get; set; }
        public DbSet<AnalyseMed> AnalyseMeds { get; set; }
        public DbSet<AnalyseMed_Cons> AnalyseMed_Cons { get; set; }
        public DbSet<AntecedentMedical> AntecedentMedicals { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Echo_Cons> Echo_Cons { get; set; }
        public DbSet<Echographie> Echographies { get; set; }
        public DbSet<InterChirur_Cons> InterChirur_Cons { get; set; }
        public DbSet<IntervChirugicale> IntervChirugicales { get; set; }
        public DbSet<IRM> IRMs { get; set; }
        public DbSet<IRM_Cons> IRM_Cons { get; set; }
        public DbSet<Med_Cons> Med_Cons { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Pat_Antecedent_Med> Pat_Antecedent_Med { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Patient_Allergie> Patient_Allergie { get; set; }
        public DbSet<Radio> Radios { get; set; }
        public DbSet<Radio_Cons> Radio_Cons { get; set; }
        public DbSet<Ree_Cons> Ree_Cons { get; set; }
        public DbSet<Reeducation> Reeducations { get; set; }
        public DbSet<RendezVou> RendezVous { get; set; }
        public DbSet<Scanner> Scanners { get; set; }
        public DbSet<Scanner_Cons> Scanner_Cons { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AllergieMap());
            modelBuilder.Configurations.Add(new AnalyseMedMap());
            modelBuilder.Configurations.Add(new AnalyseMed_ConsMap());
            modelBuilder.Configurations.Add(new AntecedentMedicalMap());
            modelBuilder.Configurations.Add(new ConsultationMap());
            modelBuilder.Configurations.Add(new Echo_ConsMap());
            modelBuilder.Configurations.Add(new EchographieMap());
            modelBuilder.Configurations.Add(new InterChirur_ConsMap());
            modelBuilder.Configurations.Add(new IntervChirugicaleMap());
            modelBuilder.Configurations.Add(new IRMMap());
            modelBuilder.Configurations.Add(new IRM_ConsMap());
            modelBuilder.Configurations.Add(new Med_ConsMap());
            modelBuilder.Configurations.Add(new MedicamentMap());
            modelBuilder.Configurations.Add(new Pat_Antecedent_MedMap());
            modelBuilder.Configurations.Add(new PatientMap());
            modelBuilder.Configurations.Add(new Patient_AllergieMap());
            modelBuilder.Configurations.Add(new RadioMap());
            modelBuilder.Configurations.Add(new Radio_ConsMap());
            modelBuilder.Configurations.Add(new Ree_ConsMap());
            modelBuilder.Configurations.Add(new ReeducationMap());
            modelBuilder.Configurations.Add(new RendezVouMap());
            modelBuilder.Configurations.Add(new ScannerMap());
            modelBuilder.Configurations.Add(new Scanner_ConsMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
