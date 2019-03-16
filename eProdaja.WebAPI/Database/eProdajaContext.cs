using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eProdaja.WebAPI.Database
{
    public partial class eProdajaContext : DbContext
    {
        public eProdajaContext()
        {
        }

        public eProdajaContext(DbContextOptions<eProdajaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dobavljaci> Dobavljaci { get; set; }
        public virtual DbSet<Izlazi> Izlazi { get; set; }
        public virtual DbSet<IzlazStavke> IzlazStavke { get; set; }
        public virtual DbSet<JediniceMjere> JediniceMjere { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Kupci> Kupci { get; set; }
        public virtual DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public virtual DbSet<Narudzbe> Narudzbe { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Proizvodi> Proizvodi { get; set; }
        public virtual DbSet<Skladista> Skladista { get; set; }
        public virtual DbSet<Ulazi> Ulazi { get; set; }
        public virtual DbSet<UlazStavke> UlazStavke { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<VrsteProizvoda> VrsteProizvoda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\REPORTING;Database=eProdaja;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dobavljaci>(entity =>
            {
                entity.HasKey(e => e.DobavljacId);

                entity.Property(e => e.DobavljacId).HasColumnName("DobavljacID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(25);

                entity.Property(e => e.KontaktOsoba).HasMaxLength(100);

                entity.Property(e => e.Napomena).HasMaxLength(500);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Web).HasMaxLength(100);

                entity.Property(e => e.ZiroRacuni).HasMaxLength(255);
            });

            modelBuilder.Entity<Izlazi>(entity =>
            {
                entity.HasKey(e => e.IzlazId);

                entity.Property(e => e.IzlazId).HasColumnName("IzlazID");

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.IznosBezPdv).HasColumnName("IznosBezPDV");

                entity.Property(e => e.IznosSaPdv).HasColumnName("IznosSaPDV");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.SkladisteId).HasColumnName("SkladisteID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Izlazi)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Izlazi_Korisnici");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.Izlazi)
                    .HasForeignKey(d => d.NarudzbaId)
                    .HasConstraintName("FK_Izlazi_Narudzbe");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.Izlazi)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Izlazi_Skladista");
            });

            modelBuilder.Entity<IzlazStavke>(entity =>
            {
                entity.HasKey(e => e.IzlazStavkaId);

                entity.Property(e => e.IzlazStavkaId).HasColumnName("IzlazStavkaID");

                entity.Property(e => e.IzlazId).HasColumnName("IzlazID");

                entity.Property(e => e.Popust).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.HasOne(d => d.Izlaz)
                    .WithMany(p => p.IzlazStavke)
                    .HasForeignKey(d => d.IzlazId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IzlazStavke_Izlazi");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.IzlazStavke)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IzlazStavke_Proizvodi");
            });

            modelBuilder.Entity<JediniceMjere>(entity =>
            {
                entity.HasKey(e => e.JedinicaMjereId);

                entity.Property(e => e.JedinicaMjereId).HasColumnName("JedinicaMjereID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.HasIndex(e => e.Email)
                    .HasName("CS_Email")
                    .IsUnique();

                entity.HasIndex(e => e.KorisnickoIme)
                    .HasName("CS_KorisnickoIme")
                    .IsUnique();

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telefon).HasMaxLength(20);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId);

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisniciUloge_Korisnici");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisniciUloge_Uloge");
            });

            modelBuilder.Entity<Kupci>(entity =>
            {
                entity.HasKey(e => e.KupacId);

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.DatumRegistracije).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NarudzbaStavke>(entity =>
            {
                entity.HasKey(e => e.NarudzbaStavkaId);

                entity.Property(e => e.NarudzbaStavkaId).HasColumnName("NarudzbaStavkaID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NarudzbaStavke_Narudzbe");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NarudzbaStavke_Proizvodi");
            });

            modelBuilder.Entity<Narudzbe>(entity =>
            {
                entity.HasKey(e => e.NarudzbaId);

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.BrojNarudzbe)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Narudzbe)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzbe_Kupci");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjene_Kupci");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjene_Proizvodi");
            });

            modelBuilder.Entity<Proizvodi>(entity =>
            {
                entity.HasKey(e => e.ProizvodId);

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.Property(e => e.JedinicaMjereId).HasColumnName("JedinicaMjereID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sifra)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VrstaId).HasColumnName("VrstaID");

                entity.HasOne(d => d.JedinicaMjere)
                    .WithMany(p => p.Proizvodi)
                    .HasForeignKey(d => d.JedinicaMjereId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvodi_JediniceMjere");

                entity.HasOne(d => d.Vrsta)
                    .WithMany(p => p.Proizvodi)
                    .HasForeignKey(d => d.VrstaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvodi_VrsteProizvoda");
            });

            modelBuilder.Entity<Skladista>(entity =>
            {
                entity.HasKey(e => e.SkladisteId);

                entity.Property(e => e.SkladisteId).HasColumnName("SkladisteID");

                entity.Property(e => e.Adresa).HasMaxLength(150);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(500);
            });

            modelBuilder.Entity<Ulazi>(entity =>
            {
                entity.HasKey(e => e.UlazId);

                entity.Property(e => e.UlazId).HasColumnName("UlazID");

                entity.Property(e => e.BrojFakture)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.DobavljacId).HasColumnName("DobavljacID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Napomena).HasMaxLength(500);

                entity.Property(e => e.Pdv)
                    .HasColumnName("PDV")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SkladisteId).HasColumnName("SkladisteID");

                entity.HasOne(d => d.Dobavljac)
                    .WithMany(p => p.Ulazi)
                    .HasForeignKey(d => d.DobavljacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ulazi_Dobavljaci");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Ulazi)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ulazi_Korisnici");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.Ulazi)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ulazi_Skladista");
            });

            modelBuilder.Entity<UlazStavke>(entity =>
            {
                entity.HasKey(e => e.UlazStavkaId);

                entity.Property(e => e.UlazStavkaId).HasColumnName("UlazStavkaID");

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.Property(e => e.UlazId).HasColumnName("UlazID");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.UlazStavke)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UlazStavke_Proizvodi");

                entity.HasOne(d => d.Ulaz)
                    .WithMany(p => p.UlazStavke)
                    .HasForeignKey(d => d.UlazId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UlazStavke_Ulazi");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });

            modelBuilder.Entity<VrsteProizvoda>(entity =>
            {
                entity.HasKey(e => e.VrstaId);

                entity.Property(e => e.VrstaId).HasColumnName("VrstaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
