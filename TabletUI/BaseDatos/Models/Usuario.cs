using System;
using System.Collections.Generic;

namespace BaseDatos.Models;

public partial class Usuario
{
    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido1 { get; set; } = null!;

    public string Apellido2 { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public int Tipousuarioid { get; set; }

    public virtual ICollection<TecnicoPorLinea> TecnicoPorLineas { get; set; } = new List<TecnicoPorLinea>();

    public virtual TipoUsuario Tipousuario { get; set; } = null!;

    public virtual ICollection<UsuarioPorLinea> UsuarioPorLineas { get; set; } = new List<UsuarioPorLinea>();
}
