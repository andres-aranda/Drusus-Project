using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos
{
    [Table("Venta")]
    public partial class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVenta { get; set; }

        public int? idCliente { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string? descripcion { get; set; }

        public int? monto { get; set; }

        [ForeignKey("idCliente")]
        public virtual Cliente? Cliente { get; set; }
    }
}
