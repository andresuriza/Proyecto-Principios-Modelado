using BaseDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Controllers;
public class UsuarioPorLineaController
{
    private MesContext context;

    public UsuarioPorLineaController()
    {
        this.context = new MesContext();
    }

    public string CreateUsuarioEnLinea(UsuarioPorLinea usr, string cedula, int lineaId, DateOnly fecha, TimeOnly horaInicio,
        TimeOnly horaFinal)
    {
        usr = new UsuarioPorLinea()
        {
            Cedula = cedula,
            Lineaid = lineaId,
            Fecha = fecha,
            Horainicio = horaInicio,
            Horafinal = horaFinal
        };
        context.UsuarioPorLineas.Add(usr);
        context.SaveChanges();
        return "Asignacion de usuario en una linea se agrego correctamente";
    }

    public string CheckUsuarioEnLinea(string cedula, int lineaId, DateOnly fecha, 
                                    TimeOnly horaInicio, TimeOnly horaFinal)
    {
        try
        {
            UsuarioPorLinea userEnLinea = context.UsuarioPorLineas.FirstOrDefault(u => u.Cedula == cedula);
            
            if (userEnLinea == null) // Si el usuario no existe
            {
                return CreateUsuarioEnLinea(userEnLinea, cedula, lineaId, fecha, horaInicio, horaFinal);
            }
            else if (userEnLinea.Lineaid != lineaId) // Si el usuario ya existe en otra linea
            {
                for (int id = 1; id < 21; id++) // Elimina otras instancias del usuario en otras lineas
                {
                    DeleteUsuarioEnLinea(cedula, id);
                    context.SaveChanges();
                    CreateUsuarioEnLinea(userEnLinea, cedula, lineaId, fecha, horaInicio, horaFinal);
                }
                return "Asignacion de usuario en esa linea ya existia";
            }
            else
            {
                return "Asignacion de usuario en esa linea ya existia";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion al intentar agregar una asignacion de usuario en una linea";
        }
    }

    public string UpdateUsuarioTime(string cedula, TimeOnly horaFinal)
    {
        try
        {
            var user = context.UsuarioPorLineas.FirstOrDefault(u => u.Cedula == cedula);

            if (user == null)
            {
                return "Usuario no existe. No lo puede actualizar si no existe";
            }
            else
            {
                user.Horafinal = horaFinal;
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

    public List<UsuarioPorLinea> GetAllUsuarios()
    {
        try
        {
            return context.UsuarioPorLineas.ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            List<UsuarioPorLinea> users = null;
            return users;
        }
    }

    public int GetUsuarioLinea(string cedula)
    {
        try
        {
            var user = context.UsuarioPorLineas.FirstOrDefault(u => u.Cedula == cedula);

            if (user == null)
            {
                return 0;
            }
            else
            {
              return user.Lineaid;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return -1;
        }
        
    }

    public TimeOnly GetUsuarioTime(string cedula)
    {
        return context.UsuarioPorLineas.FirstOrDefault(u => u.Cedula == cedula).Horainicio;
    }

    public TimeOnly GetDelays(string cedula)
    {
        return context.UsuarioPorLineas.FirstOrDefault(u => u.Cedula == cedula).Horafinal;
    }

    public string DeleteUsuarioEnLinea(string cedula, int lineaId)
    {
        try
        {
            var usuario = context.UsuarioPorLineas.Find(cedula, lineaId);
            if (usuario == null)
            {
                return "Usuario no existe. No puede borrarlo si no existe";
            }
            else
            {
                context.UsuarioPorLineas.Remove(usuario);
                context.SaveChanges();
                return "Usuario borrado correctamente";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString);
            return "Ocurrio una excepcion";
        }
    }
}
