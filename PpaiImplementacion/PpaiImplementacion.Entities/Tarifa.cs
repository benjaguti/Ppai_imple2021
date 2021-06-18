namespace PpaiImplementacion.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tarifa")]
    public partial class Tarifa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarifa()
        {
            Entrada = new HashSet<Entrada>();
            Sede = new HashSet<Sede>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTarifa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaFinVigencia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaInicioVigencia { get; set; }

        [Column(TypeName = "money")]
        public decimal? monto { get; set; }

        [Column(TypeName = "money")]
        public decimal? montoAdicionalGuia { get; set; }

        public int? idTipoVisita { get; set; }

        public int? idTipoEntrada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada> Entrada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sede> Sede { get; set; }

        public virtual TipoDeEntrada TipoDeEntrada { get; set; }

        public virtual TipoVisita TipoVisita { get; set; }

        public void mostrarMontosVigentes()
        {
            //metodo de TipoDeEntradaLogic
            mostrarNombre();
            //metodo de TipoVisitaLogic
            mostrarNombre();
        }
    }
}
