using System;
using System.Collections.Generic;

namespace Api.Models
{
    public partial class RappiRegistro
    {
        public int IdrappiRegistro { get; set; }
        public string? DirOrigen { get; set; }
        public string? DirDestino { get; set; }
        public int? Costo { get; set; }
    }
}
