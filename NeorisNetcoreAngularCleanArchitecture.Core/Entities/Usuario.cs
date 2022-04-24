using System;
using System.Collections.Generic;

#nullable disable

namespace NeorisNetcoreAngularCleanArchitecture.Core.Entities
{
    public partial class Usuario: Entity
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
    }
}
