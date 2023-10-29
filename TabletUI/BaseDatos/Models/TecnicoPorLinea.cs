using System;
using System.Collections.Generic;

namespace BaseDatos.Models;

public partial class TecnicoPorLinea
{
    public int Lineaid { get; set; }

    public string Cedulatecnico { get; set; } = null!;

    public int? Filler { get; set; }

    public virtual Usuario CedulatecnicoNavigation { get; set; } = null!;

    public virtual Linea Linea { get; set; } = null!;
}
