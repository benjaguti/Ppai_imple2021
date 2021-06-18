namespace PpaiImplementacion.Datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using PpaiImplementacion.Entidades;

    public partial class MuseoContext : DbContext
    {
        public MuseoContext()
            : base("name=MuseoContext")
        {
        }

        public virtual DbSet<Barrio> Barrio { get; set; }
        public virtual DbSet<DetalleExposicion> DetalleExposicion { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Entrada> Entrada { get; set; }
        public virtual DbSet<Exposicion> Exposicion { get; set; }
        public virtual DbSet<Obra> Obra { get; set; }
        public virtual DbSet<ReservaVisita> ReservaVisita { get; set; }
        public virtual DbSet<Sede> Sede { get; set; }
        public virtual DbSet<Sesion> Sesion { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tarifa> Tarifa { get; set; }
        public virtual DbSet<TipoDeEntrada> TipoDeEntrada { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoVisita> TipoVisita { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Barrio>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleExposicion>()
                .Property(e => e.lugarAsignado)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.tipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.cuit)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.calle)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada>()
                .Property(e => e.horaVenta)
                .HasPrecision(0);

            modelBuilder.Entity<Entrada>()
                .Property(e => e.monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Exposicion>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Exposicion>()
                .Property(e => e.horaApertura)
                .HasPrecision(0);

            modelBuilder.Entity<Exposicion>()
                .Property(e => e.horaCierre)
                .HasPrecision(0);

            modelBuilder.Entity<Obra>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.duracionExtendida)
                .HasPrecision(0);

            modelBuilder.Entity<Obra>()
                .Property(e => e.duracionResumida)
                .HasPrecision(0);

            modelBuilder.Entity<Obra>()
                .Property(e => e.nombreObra)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.valuacion)
                .IsUnicode(false);

            modelBuilder.Entity<ReservaVisita>()
                .Property(e => e.duracionEstimada)
                .HasPrecision(0);

            modelBuilder.Entity<ReservaVisita>()
                .Property(e => e.horaFinReal)
                .HasPrecision(0);

            modelBuilder.Entity<ReservaVisita>()
                .Property(e => e.horaInicioReal)
                .HasPrecision(0);

            modelBuilder.Entity<Sede>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sede>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sesion>()
                .Property(e => e.horaInicio)
                .HasPrecision(0);

            modelBuilder.Entity<Sesion>()
                .Property(e => e.horaFin)
                .HasPrecision(0);

            modelBuilder.Entity<Tarifa>()
                .Property(e => e.monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tarifa>()
                .Property(e => e.montoAdicionalGuia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TipoDeEntrada>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDeEntrada>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .Property(e => e.tipoDoc)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .HasMany(e => e.Empleado)
                .WithOptional(e => e.TipoDocumento1)
                .HasForeignKey(e => new { e.tipoDocumento, e.nroDocumento });

            modelBuilder.Entity<TipoVisita>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoVisita>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.caducidad)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.contraseña)
                .IsUnicode(false);
        }
    }
}
