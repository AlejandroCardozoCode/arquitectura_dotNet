using System;
using System.Collections.Generic;

namespace Api.Models
{
    public partial class Producto
    {
        public int Idproducto { get; set; }
        public string? Nombre { get; set; }
        public int? Precio { get; set; }
        public int? Stock { get; set; }
    }
}
