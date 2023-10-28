using BaseDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Controllers;
public class TipoEstadoController
{
    private MesContext context;
    public TipoEstadoController() 
    { 
        this.context = new MesContext();
    }

    public List<TipoEstado> GetAllTiposEstados()
    {
        try
        {
            return context.TipoEstados.ToList();
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            List<TipoEstado> tiposestado = null;
            return tiposestado;
        }
    }
}
