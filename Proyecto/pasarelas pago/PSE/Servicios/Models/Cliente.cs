using System;
using System.Collections.Generic;

namespace Servicios.Models
{
    public partial class Cliente
    {
        public int Cedula { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public long? Dinero { get; set; }
        public long? Telefono { get; set; }
        public string? Correo { get; set; }
        public long? NumTarjeta { get; set; }
        public string? FechaExp { get; set; }
    }
}
