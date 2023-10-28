using System;
using System.Collections.Generic;

namespace BaseDatos.Models;

public partial class UsuarioPorLinea
{
    public string Cedula { get; set; } = null!;

    public int Lineaid { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly Horainicio { get; set; }

    public TimeOnly Horafinal { get; set; }

    public virtual Usuario CedulaNavigation { get; set; } = null!;

    public virtual Linea Linea { get; set; } = null!;
}
