﻿using BaseDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaseDatos.Controllers;

public class LoteController
{
    private MesContext context;
    public LoteController() 
    { 
        this.context = new MesContext();
    } 

    public List<Lote> GetAllLotes()
    {
        try
        {
            return context.Lotes.ToList();
        }catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            List<Lote> listaVacia = null;
            return listaVacia;
        }
    }

    public Lote GetLoteById(int id)
    {
        try
        {
            return context.Lotes.Find(id);
        }catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Lote lotevacio = null;
            return lotevacio;
        }
    }

    public string AddLote(int id, string descripcion, int productoid, int cantidadRequerida, 
                        int cantidadObtenida = 0)
    {
        try
        {
            Lote lote = context.Lotes.Find(id);
            if (lote != null)
            {
                return "Lote con ese id ya existia en la base de datos \n";
            }
            else
            {
                lote.Id = id;
                lote.Descripcion = descripcion;
                lote.Productoid = productoid;
                lote.Cantidadrequerida = cantidadRequerida;
                lote.Cantidadobtenida = cantidadObtenida;
                context.Lotes.Add(lote);
                context.SaveChanges();
                return "Lote agregado correctamente \n";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion \n";
        }
    }

    public string UpdateLote(int id, string descripcion, int productoid, int cantidadRequerida,
                        int cantidadObtenida = 0)
    {
        try
        {
            Lote lote = context.Lotes.Find(id);
            if (lote == null)
            {
                return "Lote con ese id no existe. No puede actualizarlo si no existe \n";
            }
            else
            {
                lote.Id = id;
                lote.Descripcion = descripcion;
                lote.Productoid = productoid;
                lote.Cantidadrequerida = cantidadRequerida;
                lote.Cantidadobtenida = cantidadObtenida;
                context.Entry(lote).State = EntityState.Modified;
                context.SaveChanges();
                return "Lote actualizado correctamente \n";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion \n";
        }
    }

    public string UpdateCantidadObtenidaLote(int id, int cantidadObtenida)
    {
        try
        {
            Lote lote = context.Lotes.Find(id);
            if (lote == null)
            {
                return "Lote con ese id no existe. No puede actualizarlo si no existe \n";
            }
            else
            {
                lote.Cantidadobtenida = cantidadObtenida;
                context.Entry(lote).State = EntityState.Modified;
                context.SaveChanges();
                return "Lote actualizado correctamente \n";
            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion \n";
        }
    }
}
