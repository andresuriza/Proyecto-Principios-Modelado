using BaseDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Controllers;
internal class TecnicoPorLineaController
{
    private MesContext context;

    public TecnicoPorLineaController()
    {
        this.context = new MesContext();
    }

    public string AddTecnicoEnLinea()
    {
        return "No esta implementado todavia miher";
    }
}
