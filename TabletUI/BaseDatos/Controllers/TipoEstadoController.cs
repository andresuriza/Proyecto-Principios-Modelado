using BaseDatos.Models;
using System;
using Microsoft.EntityFrameworkCore;

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
