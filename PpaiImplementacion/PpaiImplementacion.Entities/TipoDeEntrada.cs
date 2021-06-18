namespace PpaiImplementacion.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoDeEntrada")]
    public partial class TipoDeEntrada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoDeEntrada()
        {
            Tarifa = new HashSet<Tarifa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTipoEntrada { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }

        [StringLength(30)]
        public string descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarifa> Tarifa { get; set; }

        public void mostrarNombre()
        {

        }
    }
}
