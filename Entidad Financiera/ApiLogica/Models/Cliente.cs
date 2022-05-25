using System;
using System.Collections.Generic;

namespace Api.Models
{
    public partial class Cliente
    {
        public int Cedula { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Dinero { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? NumTarjeta { get; set; }
        public string? FechaExp { get; set; }
    }
}
