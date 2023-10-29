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

    public string AddTecnicoEnLinea(int lineaId, string cedulaOperador)
    {
        try
        {
            TecnicoPorLinea tecnicoEnLinea = context.TecnicoPorLineas.Find(lineaId, cedulaOperador);
            if (tecnicoEnLinea == null)
            {
                tecnicoEnLinea = new TecnicoPorLinea()
                {
                    Lineaid = lineaId,
                    Cedulatecnico = cedulaOperador,
                    Filler = null
                };
                context.TecnicoPorLineas.Add(tecnicoEnLinea);
                context.SaveChanges();
                return "Asignacion de tecnico en linea agregada correctamente";
            }
            else
            {
                return "Asignacion de tecnico en linea ya existia";
            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion al intentar agregar una asignacion de tecnico en una linea";
        }
    }

    
}
