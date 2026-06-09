using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos
{
    [Table("Cobro")]
    public partial class Cobro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCobro { get; set; }

        public int? idCliente { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string? descripcion { get; set; }

        public int? monto { get; set; }

        [ForeignKey("idCliente")]
        public virtual Cliente? Cliente { get; set; }
    }
}
