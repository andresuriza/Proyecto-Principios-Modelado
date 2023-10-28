using System;
using System.Collections.Generic;

namespace BaseDatos.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Lote> Lotes { get; set; } = new List<Lote>();
}
