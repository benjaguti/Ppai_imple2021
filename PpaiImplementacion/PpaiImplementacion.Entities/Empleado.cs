namespace PpaiImplementacion.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            Exposicion = new HashSet<Exposicion>();
            Obra = new HashSet<Obra>();
            ReservaVisita = new HashSet<ReservaVisita>();
            Sede = new HashSet<Sede>();
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idEmpleado { get; set; }

        public int? codigoValidacion { get; set; }

        [Required]
        [StringLength(30)]
        public string nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string apellido { get; set; }

        [StringLength(30)]
        public string tipoDocumento { get; set; }

        public int? nroDocumento { get; set; }

        [StringLength(11)]
        public string cuit { get; set; }

        [StringLength(35)]
        public string calle { get; set; }

        public int? idBarrio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaIngreso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaNacimiento { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(15)]
        public string sexo { get; set; }

        public int? telefono { get; set; }

        public virtual Barrio Barrio { get; set; }

        public virtual TipoDocumento TipoDocumento1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exposicion> Exposicion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obra> Obra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaVisita> ReservaVisita { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sede> Sede { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }

        public void obtenerSede()
        {

        }
    }
}
