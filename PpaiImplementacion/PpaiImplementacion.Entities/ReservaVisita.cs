namespace PpaiImplementacion.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservaVisita")]
    public partial class ReservaVisita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idReservaVisita { get; set; }

        public int? cantAlumnos { get; set; }

        public int? cantAlumnosConfirmada { get; set; }

        public TimeSpan? duracionEstimada { get; set; }

        public DateTime? fechaHoraCreacion { get; set; }

        public DateTime? fechaHoraReserva { get; set; }

        public TimeSpan? horaFinReal { get; set; }

        public TimeSpan? horaInicioReal { get; set; }

        public int? idSede { get; set; }

        public int? idEmpleado { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Sede Sede { get; set; }
    }
}
