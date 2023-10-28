using System;
using System.Collections.Generic;

namespace BaseDatos.Models;

public partial class Linea
{
    public int Id { get; set; }

    public int Estadoid { get; set; }

    public virtual TipoEstado Estado { get; set; } = null!;

    public virtual ICollection<LotePorLinea> LotePorLineas { get; set; } = new List<LotePorLinea>();

    public virtual ICollection<UsuarioPorLinea> UsuarioPorLineas { get; set; } = new List<UsuarioPorLinea>();

    public virtual ICollection<Usuario> Cedulatecnicos { get; set; } = new List<Usuario>();
}
