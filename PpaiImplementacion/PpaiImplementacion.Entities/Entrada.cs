namespace PpaiImplementacion.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entrada")]
    public partial class Entrada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idEntrada { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaVenta { get; set; }

        public TimeSpan? horaVenta { get; set; }

        [Column(TypeName = "money")]
        public decimal? monto { get; set; }

        public int? idSede { get; set; }

        public int? idTarifa { get; set; }

        public virtual Sede Sede { get; set; }

        public virtual Tarifa Tarifa { get; set; }
    }
}
