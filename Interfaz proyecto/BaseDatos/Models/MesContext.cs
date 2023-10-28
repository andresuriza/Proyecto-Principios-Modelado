using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BaseDatos.Models;

public partial class MesContext : DbContext
{
    public MesContext()
    {
    }

    public MesContext(DbContextOptions<MesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Linea> Lineas { get; set; }

    public virtual DbSet<Lote> Lotes { get; set; }

    public virtual DbSet<LotePorLinea> LotePorLineas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<TipoEstado> TipoEstados { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioPorLinea> UsuarioPorLineas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=MES;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Linea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("linea_pkey");

            entity.ToTable("linea");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estadoid).HasColumnName("estadoid");

            entity.HasOne(d => d.Estado).WithMany(p => p.Lineas)
                .HasForeignKey(d => d.Estadoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("keys4");

            entity.HasMany(d => d.Cedulatecnicos).WithMany(p => p.Lineas)
                .UsingEntity<Dictionary<string, object>>(
                    "TecnicoPorLinea",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("Cedulatecnico")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("keys9"),
                    l => l.HasOne<Linea>().WithMany()
                        .HasForeignKey("Lineaid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("keys8"),
                    j =>
                    {
                        j.HasKey("Lineaid", "Cedulatecnico").HasName("tecnico_por_linea_pkey");
                        j.ToTable("tecnico_por_linea");
                        j.IndexerProperty<int>("Lineaid").HasColumnName("lineaid");
                        j.IndexerProperty<string>("Cedulatecnico")
                            .HasMaxLength(9)
                            .HasColumnName("cedulatecnico");
                    });
        });

        modelBuilder.Entity<Lote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lote_pkey");

            entity.ToTable("lote");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidadobtenida).HasColumnName("cantidadobtenida");
            entity.Property(e => e.Cantidadrequerida).HasColumnName("cantidadrequerida");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .HasColumnName("descripcion");
            entity.Property(e => e.Productoid).HasColumnName("productoid");

            entity.HasOne(d => d.Producto).WithMany(p => p.Lotes)
                .HasForeignKey(d => d.Productoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("keys5");
        });

        modelBuilder.Entity<LotePorLinea>(entity =>
        {
            entity.HasKey(e => new { e.Lineaid, e.Loteid }).HasName("lote_por_linea_pkey");

            entity.ToTable("lote_por_linea");

            entity.Property(e => e.Lineaid).HasColumnName("lineaid");
            entity.Property(e => e.Loteid).HasColumnName("loteid");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Horafinal).HasColumnName("horafinal");
            entity.Property(e => e.Horainicio).HasColumnName("horainicio");

            entity.HasOne(d => d.Linea).WithMany(p => p.LotePorLineas)
                .HasForeignKey(d => d.Lineaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("keys6");

            entity.HasOne(d => d.Lote).WithMany(p => p.LotePorLineas)
                .HasForeignKey(d => d.Loteid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("keys7");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("producto_pkey");

            entity.ToTable("producto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipo_estado_pkey");

            entity.ToTable("tipo_estado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipo_usuario_pkey");

            entity.ToTable("tipo_usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Cedula).HasName("usuario_pkey");

            entity.ToTable("usuario");

            entity.Property(e => e.Cedula)
                .HasMaxLength(9)
                .HasColumnName("cedula");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(10)
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(10)
                .HasColumnName("apellido2");
            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(10)
                .HasColumnName("nombre");
            entity.Property(e => e.Tipousuarioid).HasColumnName("tipousuarioid");

            entity.HasOne(d => d.Tipousuario).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Tipousuarioid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("keys1");
        });

        modelBuilder.Entity<UsuarioPorLinea>(entity =>
        {
            entity.HasKey(e => new { e.Cedula, e.Lineaid }).HasName("usuario_por_linea_pkey");

            entity.ToTable("usuario_por_linea");

            entity.Property(e => e.Cedula)
                .HasMaxLength(9)
                .HasColumnName("cedula");
            entity.Property(e => e.Lineaid).HasColumnName("lineaid");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Horafinal).HasColumnName("horafinal");
            entity.Property(e => e.Horainicio).HasColumnName("horainicio");

            entity.HasOne(d => d.CedulaNavigation).WithMany(p => p.UsuarioPorLineas)
                .HasForeignKey(d => d.Cedula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("keys2");

            entity.HasOne(d => d.Linea).WithMany(p => p.UsuarioPorLineas)
                .HasForeignKey(d => d.Lineaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("keys3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
