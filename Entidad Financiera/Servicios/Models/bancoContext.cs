using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Servicios.Models
{
    public partial class bancoContext : DbContext
    {
        public bancoContext()
        {
        }

        public bancoContext(DbContextOptions<bancoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=banco;user=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PRIMARY");

                entity.ToTable("clientes");

                entity.Property(e => e.Cedula).HasColumnName("cedula");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(45)
                    .HasColumnName("apellido");

                entity.Property(e => e.Correo)
                    .HasMaxLength(45)
                    .HasColumnName("correo");

                entity.Property(e => e.Dinero).HasColumnName("dinero");

                entity.Property(e => e.FechaExp)
                    .HasMaxLength(45)
                    .HasColumnName("fechaExp");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumTarjeta)
                    .HasMaxLength(45)
                    .HasColumnName("numTarjeta");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(45)
                    .HasColumnName("telefono");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
