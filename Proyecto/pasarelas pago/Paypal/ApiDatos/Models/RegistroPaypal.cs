using System;
using System.Collections.Generic;

namespace Api.Models
{
    public partial class RegistroPaypal
    {
        public int IdregistroPaypal { get; set; }
        public int? Cedula { get; set; }
        public int? Valor { get; set; }
    }
}
