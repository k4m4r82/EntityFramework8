using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DemoComplexTypes.Models.Mapping;

namespace DemoComplexTypes.Models
{
    public partial class DemoComplexTypesContext : DbContext
    {
        static DemoComplexTypesContext()
        {
            Database.SetInitializer<DemoComplexTypesContext>(null);
        }

        public DemoComplexTypesContext()
            : base("Name=DemoComplexTypesContext")
        {
        }

        public DbSet<Guru> Gurus { get; set; }
        public DbSet<Pegawai> Pegawais { get; set; }
        public DbSet<Siswa> Siswas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GuruMap());
            modelBuilder.Configurations.Add(new PegawaiMap());
            modelBuilder.Configurations.Add(new SiswaMap());
        }
    }
}
