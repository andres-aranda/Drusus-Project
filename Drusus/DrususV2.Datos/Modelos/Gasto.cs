using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos
{
    [Table("Gasto")]
    public partial class Gasto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idGasto { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string? descripcion { get; set; }

        public int? costo { get; set; }
    }
}
