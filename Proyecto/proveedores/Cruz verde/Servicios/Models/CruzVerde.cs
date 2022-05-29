using System;
using System.Collections.Generic;

namespace Servicios.Models
{
    public partial class CruzVerde
    {
        public int IdCatalogo { get; set; }
        public string? Nombre { get; set; }
        public int? ValorProducProv { get; set; }
        public int? Disponibilidad { get; set; }
        public string? Descripcion { get; set; }
        public string? Contraindicaciones { get; set; }
    }
}
