using System;
using System.Collections.Generic;

namespace BaseDatos.Models;

public partial class LotePorLinea
{
    public int Lineaid { get; set; }

    public string Loteid { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public TimeOnly Horainicio { get; set; }

    public TimeOnly Horafinal { get; set; }

    public virtual Linea Linea { get; set; } = null!;

    public virtual Lote Lote { get; set; } = null!;
}
