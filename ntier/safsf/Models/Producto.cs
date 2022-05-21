using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace safsf.Models
{
    public partial class Producto
    {
        public int Idproducto { get; set; }
        public string? Nombre { get; set; }
        public int? Precio { get; set; }
        public int? Unidades { get; set; }
        public string? Presentacion { get; set; }
    }
}