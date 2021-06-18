namespace PpaiImplementacion.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sesion")]
    public partial class Sesion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idSesion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaFin { get; set; }

        public TimeSpan? horaInicio { get; set; }

        public TimeSpan? horaFin { get; set; }

        public int? idUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }

        public void getEmpleadoEnSesion()
        {
            //Este metodo pertenece a UsuarioLogic
            obtenerEmpleado();
        }
    }
}
