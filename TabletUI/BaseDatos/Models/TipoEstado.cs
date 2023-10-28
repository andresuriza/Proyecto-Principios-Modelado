using System;
using System.Collections.Generic;

namespace BaseDatos.Models;

public partial class TipoEstado
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Linea> Lineas { get; set; } = new List<Linea>();
}
