using BaseDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BaseDatos.Controllers;
public class UsuarioController
{
    private MesContext context;
    public UsuarioController()
    {
        this.context = new MesContext();
    }

    public List<Usuario> GetAllUsuarios()
    {
        try
        {
            return context.Usuarios.ToList();
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            List<Usuario> users = null;
            return users;
        }
    }
    public Usuario GetUsuarioByCedula(string cedula)
    {
        try
        {
            return context.Usuarios.FirstOrDefault(u => u.Cedula == cedula);
        }
        
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Usuario result = null;
            return result;
        }
    }

    public Usuario GetUsuarioByCodigo(string codigo)
    {
        try
        {
            return context.Usuarios.FirstOrDefault(u => u.Codigo == codigo);
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Usuario result = null;
            return result;
        }
    }

    public string GetUsuarioName(string codigo)
    {
        if (GetUsuarioByCodigo(codigo) == null)
        {
            return "n/a";
        }

        else
        {
            return GetUsuarioByCodigo(codigo).Codigo;
        }
    }

    public int GetUsuarioType(string codigo)
    {
        
        return GetUsuarioByCodigo(codigo).Tipousuarioid;
        
    }

    public string AddUsuario(string cedula, string nombre, string ap1,
                string ap2, string codigo, int tipoUsuario)
    {
        try
        {

            Usuario user = context.Usuarios.Find(cedula);

            if (user != null)
            {
                return "Usuario ya existia, no puede agregarlo dos veces";
            }
            else
            {
                Usuario user2 = new Usuario
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido1 = ap1,
                    Apellido2 = ap2,
                    Codigo = codigo,
                    Tipousuarioid = tipoUsuario
                };
                
                context.Usuarios.Add(user2);
                context.SaveChanges();
                return "Usuario agregado correctamente";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion";
        }    
    }
    public string UpdateUsuario(string cedula, string nombre, string ap1,
                string ap2, string codigo, int tipoUsuario)
    {
        try
        {
            Usuario user = context.Usuarios.Find(cedula);

            if (user == null)
            {
                return "Usuario no existe. No lo puede actualizar si no existe";
            }
            else
            {
                user.Cedula = cedula;
                user.Nombre = nombre;
                user.Apellido1 = ap1;
                user.Apellido2 = ap2;
                user.Tipousuarioid = tipoUsuario;
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
                return "Usuario actualizado correctamente";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion"; 
        }
    }
    public string DeleteUsuario(string cedula)
    {
        try
        {
            var usuario = context.Usuarios.Find(cedula);
            if (usuario == null)
            {
                return "Usuario no existe. No puede borrarlo si no existe";
            }
            else
            {
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
                return "Usuario borrado correctamente";
            }
        }catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString);
            return "Ocurrio una excepcion";
            }
    }
}
