using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dotnet.Models
{
    public partial class arquitecturaContext : DbContext
    {
        public arquitecturaContext()
        {
        }

        public arquitecturaContext(DbContextOptions<arquitecturaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=arquitectura;user=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("PRIMARY");

                entity.ToTable("producto");

                entity.Property(e => e.Idproducto)
                    .ValueGeneratedNever()
                    .HasColumnName("idproducto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.Property(e => e.Idusuario)
                    .ValueGeneratedNever()
                    .HasColumnName("idusuario");

                entity.Property(e => e.Contra)
                    .HasMaxLength(45)
                    .HasColumnName("contra");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
