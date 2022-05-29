using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Api.Models
{
    public partial class proveedoresContext : DbContext
    {
        public proveedoresContext()
        {
        }

        public proveedoresContext(DbContextOptions<proveedoresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CruzVerde> CruzVerdes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=proveedores;user=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<CruzVerde>(entity =>
            {
                entity.HasKey(e => e.IdCatalogo)
                    .HasName("PRIMARY");

                entity.ToTable("cruz_verde");

                entity.Property(e => e.IdCatalogo)
                    .ValueGeneratedNever()
                    .HasColumnName("idCatalogo");

                entity.Property(e => e.Contraindicaciones)
                    .HasMaxLength(45)
                    .HasColumnName("contraindicaciones");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Disponibilidad).HasColumnName("disponibilidad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");

                entity.Property(e => e.ValorProducProv).HasColumnName("valorProducProv");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
