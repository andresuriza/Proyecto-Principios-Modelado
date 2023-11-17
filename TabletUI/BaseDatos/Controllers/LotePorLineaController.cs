using BaseDatos.Models;
using static System.DateOnly;
using static System.TimeOnly;
using System;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BaseDatos.Controllers;
public class LotePorLineaController
{
    private MesContext context;

    public LotePorLineaController()
    {
        this.context = new MesContext();
    }
    public List<LotePorLinea> GetAllLotesPorLineas()
    {
        try
        {
            return context.LotePorLineas.ToList();
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            List<LotePorLinea> vacia = null;
            return vacia;
        }
    }
    public string AddLotePorLinea(string idLote, int idLinea, DateOnly fecha, 
                                  TimeOnly horaInicio, TimeOnly horaFinal)
    {
        try
        {
            LotePorLinea lotePorLinea = context.LotePorLineas.FirstOrDefault(u => u.Loteid == idLote);
            //LotePorLinea lotePorLinea3 = context.LotePorLineas.FirstOrDefault(u => u.Lineaid == idLinea);

            if (lotePorLinea != null)
            {
                return "El lote ya se asigno a una linea. No puede asignar el lote dos veces a la misma linea";
            }
            else
            {
                //DateTime fechaEjemplo = DateTime.Now;

                LotePorLinea lotePorLinea2 = new LotePorLinea()
                {
                    Lineaid = idLinea,
                    Loteid = idLote,
                    Fecha = fecha,
                    Horainicio = horaInicio,
                    Horafinal = horaFinal
                };

                context.LotePorLineas.Add(lotePorLinea2);
                context.SaveChanges();
                return "Asignacion de lote en una linea se agrego correctamente";
            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "No se pudo asignar el lote a una linea. Ocurrio una excepcion";
        }
    }
    public string UpdateLotePorLinea(string idLote, int idLinea, DateOnly fecha,
                                  TimeOnly horaInicio, TimeOnly horaFinal)
    {
        try
        {
            LotePorLinea loteEnLinea = context.LotePorLineas.Find(idLinea, idLote);
            if(loteEnLinea == null)
            {
                return "Asignacion de lote en esta linea no existe. No lo puede actualizar pues no existe";
            }
            else
            {
                loteEnLinea.Loteid = idLote;
                loteEnLinea.Lineaid = idLinea;
                loteEnLinea.Fecha = fecha;
                loteEnLinea.Horainicio = horaInicio;
                loteEnLinea.Horafinal = horaFinal;
                context.Entry(loteEnLinea).State = EntityState.Modified;
                context.SaveChanges();
                return "Asignacion de lote en linea se actualizo correctamente";
            }
        }catch(Exception ex) 
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion al intentar borrar la asignacion de un lote en una linea";
        }
    }

    public TimeOnly GetLoteTime(string idLote)
    {
        return context.LotePorLineas.FirstOrDefault(u => u.Loteid == idLote).Horainicio;
    }

    public string DeleteLotePorLinea(string idLote, int idLinea)
    {
        try
        {
            //var lotePorLinea3 = context.LotePorLineas.Find(idLote, idLinea);
            var lotePorLinea = context.LotePorLineas.FirstOrDefault(u => u.Loteid == idLote);

            if (lotePorLinea == null)
            {
                return "Lote no asignado a esa linea. No lo puede borrar pues no existe esa asignacion";
            }
            else
            {
                context.LotePorLineas.Remove(lotePorLinea);
        
                context.SaveChanges();
                return "Asignacion de lote en una linea se borro correctamente";
            }
        } catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion al borrar la asignacion de lote en una linea";
        }
    }
}
