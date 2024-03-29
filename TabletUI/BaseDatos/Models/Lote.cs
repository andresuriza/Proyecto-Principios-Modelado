﻿using System;
using System.Collections.Generic;

namespace BaseDatos.Models;

public partial class Lote
{
    public string Id { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Productoid { get; set; }

    public int Cantidadrequerida { get; set; }

    public int Cantidadobtenida { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<LotePorLinea> LotePorLineas { get; set; } = new List<LotePorLinea>();

    public virtual Producto Producto { get; set; } = null!;
}
