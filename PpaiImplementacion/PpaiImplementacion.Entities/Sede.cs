namespace PpaiImplementacion.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sede")]
    public partial class Sede
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sede()
        {
            Entrada = new HashSet<Entrada>();
            ReservaVisita = new HashSet<ReservaVisita>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idSede { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        public int? cantMaxVisitantes { get; set; }

        public int? cantMaxPorGuia { get; set; }

        public int? idTarifa { get; set; }

        public int? idExposicion { get; set; }

        public int? idEmpleado { get; set; }

        public virtual Empleado Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada> Entrada { get; set; }

        public virtual Exposicion Exposicion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaVisita> ReservaVisita { get; set; }

        public virtual Tarifa Tarifa { get; set; }

        public void obtenerTarifasVigentes()
        {
            mostrarMontosVigentes();
        }
    }
}
