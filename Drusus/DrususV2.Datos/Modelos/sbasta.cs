using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos
{
    [Table("sbasta")]
    public partial class sbasta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int? monto { get; set; }

        [StringLength(50)]
        public string? descripcion { get; set; }

        public int? idCliente { get; set; }

        public bool? mia { get; set; }
    }
}
