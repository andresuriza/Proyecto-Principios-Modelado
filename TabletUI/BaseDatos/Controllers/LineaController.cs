using BaseDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BaseDatos.Controllers;
public class LineaController
{
    private MesContext context;
    public LineaController()
    {
        this.context = new MesContext();
    }

    public List<Linea> GetAllLineas()
    {
        try
        {
            return context.Lineas.ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            List<Linea> lineas = null;
            return lineas;
        }
    }
    public void AddLinea(int estadoId)
    {
        try
        {
            Linea nuevaLinea = new Linea
            {
                Estadoid = estadoId,
            };
            context.Lineas.Add(nuevaLinea);
            context.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public void UpdateLinea(int lineaId, int estadoId)
    {
        try
        {
            Linea lineaToUpdate = context.Lineas.Find(lineaId);
            if (lineaToUpdate != null)
            {
                lineaToUpdate.Estadoid = estadoId;
                context.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
