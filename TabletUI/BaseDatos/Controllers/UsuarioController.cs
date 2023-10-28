
using System;
using System.Collections.Generic;
using System.Linq;
using BaseDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseDatos.Controllers;
public class UsuarioController
{
    private MesContext context;

    public UsuarioController(MesContext context)
    {
        this.context = context;
    }

    public List<Usuario> GetAllUsuarios()
    {
        return context.Usuarios.ToList();
    }

    public Usuario GetUsuarioByCedula(string cedula)
    {
        return context.Usuarios.FirstOrDefault(u => u.Cedula == cedula);
    }

    public void AddUsuario(Usuario Usuario)
    {
        context.Usuarios.Add(Usuario);
        context.SaveChanges();
    }

    public void UpdateUsuario(Usuario Usuario)
    {
        context.Usuarios.Update(Usuario);
        context.SaveChanges();
    }

    public void DeleteUsuario(string cedula)
    {
        var Usuario = GetUsuarioByCedula(cedula);
        if (Usuario != null)
        {
            context.Usuarios.Remove(Usuario);
            context.SaveChanges();
        }
    }
}
