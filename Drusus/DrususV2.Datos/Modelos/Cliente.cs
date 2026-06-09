using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos
{
    [Table("Cliente")]
    public partial class Cliente
    {
        public Cliente()
        {
            Cobroes = new HashSet<Cobro>();
            Ventas = new HashSet<Venta>();
        }

        [NotMapped]
        public string apellidoNombre => apellido + " " + nombre;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliente { get; set; }

        [StringLength(50)]
        public string? nombre { get; set; }

        [StringLength(50)]
        public string? apellido { get; set; }

        [StringLength(50)]
        public string? cuil { get; set; }

        public string? direccion { get; set; }

        public int? sieteDias { get; set; }
        public int? catorceDias { get; set; }
        public int? veintiunDias { get; set; }
        public int? masVentiunDias { get; set; }
        public int? deudaUSS { get; set; }

        public virtual ICollection<Cobro> Cobroes { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
