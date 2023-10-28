using BaseDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BaseDatos.Controllers
{
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
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Usuario result = null;
                return result;
            }
        }
        public void AddUsuario(string cedula, string nombre, string ap1,
                    string ap2, string codigo, int tipoUsuario)
        {
            try
            {
                Usuario user = new Usuario()
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido1 = ap1,
                    Apellido2 = ap2,
                    Codigo = codigo,
                    Tipousuarioid = tipoUsuario
                };
                context.Usuarios.Add(user);
                context.SaveChanges();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }    
        }
        public int UpdateUsuario(string cedula, string nombre, string ap1,
                    string ap2, string codigo, int tipoUsuario)
        {
            try
            {
                Usuario user = context.Usuarios.Find(cedula);

                if (user == null)
                {
                    return 1;
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
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 2; 
            }
        }
        public int DeleteUsuario(string cedula)
        {
            try
            {
                var usuario = context.Usuarios.Find(cedula);
                if (usuario == null)
                {
                    return 1;
                }
                else
                {
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                    return 0;
                }
            }catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString);
                return 2;
             }
        }
    }
}
