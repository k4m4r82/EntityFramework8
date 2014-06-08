using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DemoComplexTypes.Models.Mapping
{
    public class GuruMap : EntityTypeConfiguration<Guru>
    {
        public GuruMap()
        {
            // Primary Key
            this.HasKey(t => t.Nik);

            // Properties
            this.Property(t => t.Nik)
                .IsRequired()
                .HasMaxLength(20);

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
            this.ToTable("Guru");
            this.Property(t => t.Nik).HasColumnName("Nik");
            this.Property(t => t.Nama).HasColumnName("Nama");
            this.Property(t => t.JumlahJamMengajar).HasColumnName("JumlahJamMengajar");
            //this.Property(t => t.Jalan).HasColumnName("Jalan");
            //this.Property(t => t.Kota).HasColumnName("Kota");
            //this.Property(t => t.Provinsi).HasColumnName("Provinsi");
            //this.Property(t => t.KodePos).HasColumnName("KodePos");
        }
    }
}
