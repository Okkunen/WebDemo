using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspNetCoreBackend.Database
{
    public partial class KorttiappiContext : DbContext
    {
        public KorttiappiContext()
        {
        }

        public KorttiappiContext(DbContextOptions<KorttiappiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategoriat> Kategoriat { get; set; }
        public virtual DbSet<Kortit> Kortit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=imas\\sqlexpress;Database=Korttiappi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategoriat>(entity =>
            {
                entity.HasKey(e => e.KategoriaId);

                entity.Property(e => e.Kategoria)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Kortit>(entity =>
            {
                entity.HasKey(e => e.KorttiId);

                entity.Property(e => e.Kaannos).HasMaxLength(100);

                entity.Property(e => e.KategoriaId).HasColumnName("KategoriaID");

                entity.Property(e => e.Sana).HasMaxLength(100);

                entity.HasOne(d => d.Kategoria)
                    .WithMany(p => p.Kortit)
                    .HasForeignKey(d => d.KategoriaId)
                    .HasConstraintName("FK_Kortit_Kategoriat");
            });
        }
    }
}
