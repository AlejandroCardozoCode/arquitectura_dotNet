using System;
using System.Collections.Generic;

namespace Api.Models
{
    public partial class UberRegistro
    {
        public int IduberRegistro { get; set; }
        public string? DirOrigen { get; set; }
        public string? DirDestino { get; set; }
        public int? Costo { get; set; }
    }
}
