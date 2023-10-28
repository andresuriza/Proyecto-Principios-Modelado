using BaseDatos.Controllers;
using BaseDatos.Models;
using System;
using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {
        UsuarioController uc = new UsuarioController();
        LineaController lc = new LineaController();
        TipoUsuarioController tuc = new TipoUsuarioController();

        //uc.AddUsuario("118875645", "Jimena", "Leon", "Huertas", "5645", 1);
        List<Usuario> listaUsers = uc.GetAllUsuarios();
        List<Linea> listaLineas = lc.GetAllLineas();
        List<TipoUsuario> listaTipoUsuarios = tuc.GetAllTipoUsuarios();

        Console.WriteLine("USUARIOS EN LA BASE DE DATOS");
        for (int i = 0; i < listaUsers.Count; i++)
        {
            Console.WriteLine("Cedula: " + listaUsers[i].Cedula);
        }
        Console.WriteLine("\n");


        Console.WriteLine("LINEAS EN LA BASE DE DATOS");
        for (int i = 0;i < listaLineas.Count; i++)
        {
            Console.WriteLine("Id: " + listaLineas[i].Id + " Estado: " + listaLineas[i].Estadoid);
        }
        Console.WriteLine("\n");


        Console.WriteLine("TIPOS DE USUARIOS EN LA BASE DE DATOS");
        for (int i = 0;i< listaTipoUsuarios.Count; i++) 
        {
            Console.WriteLine("Id: " + listaTipoUsuarios[i].Id + " Descripcion: " + listaTipoUsuarios[i].Descripcion);
        }
        Console.WriteLine("\n");


        Console.WriteLine("Prueba completada :D");
    }
}
