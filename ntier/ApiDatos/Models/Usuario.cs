using System;
using System.Collections.Generic;

namespace Api.Models
{
    public partial class Usuario
    {
        public int Idusuario { get; set; }
        public string? Nombre { get; set; }
        public string? Contra { get; set; }
    }
}
