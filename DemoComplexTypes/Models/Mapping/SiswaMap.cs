using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DemoComplexTypes.Models.Mapping
{
    public class SiswaMap : EntityTypeConfiguration<Siswa>
    {
        public SiswaMap()
        {
            // Primary Key
            this.HasKey(t => t.Nis);

            // Properties
            this.Property(t => t.Nis)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Nama)
                .HasMaxLength(30);

            //this.Property(t => t.Jalan)
            //    .HasMaxLength(100);

            //this.Property(t => t.Kota)
            //    .HasMaxLength(50);

            //this.Property(t => t.Provinsi)
            //    .HasMaxLength(50);

            //this.Property(t => t.KodePos)
            //    .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Siswa");
            this.Property(t => t.Nis).HasColumnName("Nis");
            this.Property(t => t.Nama).HasColumnName("Nama");
            //this.Property(t => t.Jalan).HasColumnName("Jalan");
            //this.Property(t => t.Kota).HasColumnName("Kota");
            //this.Property(t => t.Provinsi).HasColumnName("Provinsi");
            //this.Property(t => t.KodePos).HasColumnName("KodePos");
        }
    }
}
