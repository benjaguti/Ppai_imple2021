namespace PpaiImplementacion.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Obra")]
    public partial class Obra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Obra()
        {
            DetalleExposicion = new HashSet<DetalleExposicion>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idObra { get; set; }

        public int? alto { get; set; }

        public int? ancho { get; set; }

        public int? codigoSensor { get; set; }

        [StringLength(30)]
        public string descripcion { get; set; }

        public TimeSpan? duracionExtendida { get; set; }

        public TimeSpan? duracionResumida { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaCreacion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaPrimeroIngreso { get; set; }

        [StringLength(30)]
        public string nombreObra { get; set; }

        public int? peso { get; set; }

        [StringLength(30)]
        public string valuacion { get; set; }

        public int? idEmpleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleExposicion> DetalleExposicion { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
