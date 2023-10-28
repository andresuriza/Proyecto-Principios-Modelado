using BaseDatos.Models;
using System;
using System.Collections.Generic;
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

    public string AddUsuarioEnLinea(string cedula, int lineaId, DateOnly fecha, 
                                    TimeOnly horaInicio, TimeOnly horaFinal)
    {
        try
        {
            UsuarioPorLinea userEnLinea = context.UsuarioPorLineas.Find(cedula, lineaId);
            if (userEnLinea == null)
            {
                userEnLinea = new UsuarioPorLinea()
                {
                    Cedula = cedula,
                    Lineaid = lineaId,
                    Fecha = fecha,
                    Horainicio = horaInicio,
                    Horafinal = horaFinal
                };
                context.UsuarioPorLineas.Add(userEnLinea);
                context.SaveChanges();
                return "Asignacion de usuario en una linea se agrego correctamente";
            }
            else
            {
                return "Asignacion de usuario en esa linea ya existia";
            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion al intentar agregar una asignacion de usuario en una linea";
        }
    }
}
