using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Servicios.Models
{
    public partial class envioContext : DbContext
    {
        public envioContext()
        {
        }

        public envioContext(DbContextOptions<envioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DomiciliosRegistro> DomiciliosRegistros { get; set; } = null!;
        public virtual DbSet<RappiRegistro> RappiRegistros { get; set; } = null!;
        public virtual DbSet<UberRegistro> UberRegistros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=envio;user=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<DomiciliosRegistro>(entity =>
            {
                entity.HasKey(e => e.IddomiciliosRegistro)
                    .HasName("PRIMARY");

                entity.ToTable("domicilios_registro");

                entity.Property(e => e.IddomiciliosRegistro).HasColumnName("iddomicilios_registro");

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.DirDestino)
                    .HasMaxLength(45)
                    .HasColumnName("dirDestino");

                entity.Property(e => e.DirOrigen)
                    .HasMaxLength(45)
                    .HasColumnName("dirOrigen");
            });

            modelBuilder.Entity<RappiRegistro>(entity =>
            {
                entity.HasKey(e => e.IdrappiRegistro)
                    .HasName("PRIMARY");

                entity.ToTable("rappi_registro");

                entity.Property(e => e.IdrappiRegistro).HasColumnName("idrappi_registro");

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.DirDestino)
                    .HasMaxLength(45)
                    .HasColumnName("dirDestino");

                entity.Property(e => e.DirOrigen)
                    .HasMaxLength(45)
                    .HasColumnName("dirOrigen");
            });

            modelBuilder.Entity<UberRegistro>(entity =>
            {
                entity.HasKey(e => e.IduberRegistro)
                    .HasName("PRIMARY");

                entity.ToTable("uber_registro");

                entity.Property(e => e.IduberRegistro).HasColumnName("iduber_registro");

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.DirDestino)
                    .HasMaxLength(45)
                    .HasColumnName("dirDestino");

                entity.Property(e => e.DirOrigen)
                    .HasMaxLength(45)
                    .HasColumnName("dirOrigen");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
