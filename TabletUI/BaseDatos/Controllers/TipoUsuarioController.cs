using BaseDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BaseDatos.Controllers;

public class TipoUsuarioController
{
    private MesContext context;

    public TipoUsuarioController()
    {
        this.context = new MesContext();
    }

    public List<TipoUsuario> GetAllTiposUsuarios()
    {
        try
        {
            return context.TipoUsuarios.ToList();
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            List<TipoUsuario> listaVacia = null;
            return listaVacia;
        }
    }
}