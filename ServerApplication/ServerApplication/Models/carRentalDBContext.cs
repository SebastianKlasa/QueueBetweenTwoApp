using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ServerApplication.Models
{
    public partial class carRentalDBContext : DbContext
    {
        public carRentalDBContext()
        {
        }

        public carRentalDBContext(DbContextOptions<carRentalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Hire> Hire { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SEBASTIAN\\DB; Database=carRentalDB; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Cars>(entity =>
            {
                entity.HasKey(e => e.CarId)
                    .HasName("PK__Cars__1436F09471649B6E");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.CenaZaGodzine).HasColumnName("cena_za_godzine");

                entity.Property(e => e.Dostepnosc).HasColumnName("dostepnosc");

                entity.Property(e => e.LiczbaDrzwi).HasColumnName("liczba_drzwi");

                entity.Property(e => e.Marka)
                    .IsRequired()
                    .HasColumnName("marka")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nadwozie)
                    .IsRequired()
                    .HasColumnName("nadwozie")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rocznik)
                    .IsRequired()
                    .HasColumnName("rocznik")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hire>(entity =>
            {
                entity.Property(e => e.HireId).HasColumnName("hireID");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.CenaWynajmu).HasColumnName("cena_wynajmu");

                entity.Property(e => e.CzyOplacone).HasColumnName("czy_oplacone");

                entity.Property(e => e.DataWynajmu)
                    .HasColumnName("data_wynajmu")
                    .HasColumnType("date");

                entity.Property(e => e.DataZakonczeniaWynajmu)
                    .HasColumnName("data_zakonczenia_wynajmu")
                    .HasColumnType("date");

                entity.Property(e => e.StatusWypozyczenia)
                    .HasColumnName("status_wypozyczenia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Hire)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Hire__carID__71D1E811");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Hire)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Hire__userID__70DDC3D8");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__CB9A1CDF1D728975");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasColumnName("adres")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataUrodzenia)
                    .HasColumnName("data_urodzenia")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Haslo)
                    .IsRequired()
                    .HasColumnName("haslo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasColumnName("imie")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasColumnName("nazwisko")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpcjeZarzadzania).HasColumnName("opcje_zarzadzania");

                entity.Property(e => e.PotwierdzHaslo)
                    .IsRequired()
                    .HasColumnName("potwierdz_haslo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasColumnName("telefon")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });
        }
    }
}
