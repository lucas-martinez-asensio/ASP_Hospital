﻿using System;
using System.Collections.Generic;

namespace MiPrimeraAplicacionEnNetCore.Models
{
    public partial class TipoUsuarioPaginaBoton
    {
        public int Iidtipousuariopaginaboton { get; set; }
        public int? Iidtipousuariopagina { get; set; }
        public int? Iidboton { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual Boton? IidbotonNavigation { get; set; }
        public virtual TipoUsuarioPagina? IidtipousuariopaginaNavigation { get; set; }
    }
}
