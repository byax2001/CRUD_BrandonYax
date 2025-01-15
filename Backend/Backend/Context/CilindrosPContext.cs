using System;
using System.Collections.Generic;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context;

public partial class CilindrosPContext : DbContext
{
    public CilindrosPContext()
    {
    }

    public CilindrosPContext(DbContextOptions<CilindrosPContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cilindro> Cilindros { get; set; }

    public virtual DbSet<Envase> Envases { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Brandon\\SQLBYAXDB; Encrypt=False; DataBase=CilindrosP; Trust Server Certificate=true; User Id=byaxC; Password=41L35yax; MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cilindro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cilindro__3213E83F69A5F97F");

            entity.ToTable("Cilindro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Idenvase).HasColumnName("idenvase");
            entity.Property(e => e.Idproducto).HasColumnName("idproducto");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serie");

            entity.HasOne(d => d.IdenvaseNavigation).WithMany(p => p.Cilindros)
                .HasForeignKey(d => d.Idenvase)
                .HasConstraintName("FK__Cilindro__idenva__5535A963");

            entity.HasOne(d => d.IdproductoNavigation).WithMany(p => p.Cilindros)
                .HasForeignKey(d => d.Idproducto)
                .HasConstraintName("FK__Cilindro__idprod__5629CD9C");
        });

        modelBuilder.Entity<Envase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Envase__3213E83FFF1A1DAC");

            entity.ToTable("Envase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3213E83F177DBFBF");

            entity.ToTable("Producto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
