namespace PpaiImplementacion.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exposicion")]
    public partial class Exposicion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exposicion()
        {
            Sede = new HashSet<Sede>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idExposicion { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }

        public DateTime? fechaInicio { get; set; }

        public DateTime? fechaFin { get; set; }

        public DateTime? fechaInicioReplanificada { get; set; }

        public DateTime? fechaFinReplanificada { get; set; }

        public TimeSpan? horaApertura { get; set; }

        public TimeSpan? horaCierre { get; set; }

        public int? idEmpleado { get; set; }

        public int? idDetalleExposicion { get; set; }

        public virtual DetalleExposicion DetalleExposicion { get; set; }

        public virtual Empleado Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sede> Sede { get; set; }
    }
}
