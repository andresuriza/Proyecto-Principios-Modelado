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
        TipoEstadoController tec = new TipoEstadoController();


        // ESTOS METODOS AGARRAN LOS DATOS DESDE LA BASE DE DATOS

        //uc.AddUsuario("118875645", "Jimena", "Leon", "Huertas", "5645", 1);
        List<Usuario> listaUsers = uc.GetAllUsuarios();
        List<Linea> listaLineas = lc.GetAllLineas();
        List<TipoUsuario> listaTiposUsuarios = tuc.GetAllTiposUsuarios();
        List<TipoEstado> listaTiposEstados = tec.GetAllTiposEstados();


        // IMPRESION DE LOS DATOS EN CONSOLA

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
        for (int i = 0;i< listaTiposUsuarios.Count; i++) 
        {
            Console.WriteLine("Id: " + listaTiposUsuarios[i].Id + " Descripcion: " + listaTiposUsuarios[i].Descripcion);
        }
        Console.WriteLine("\n");


        Console.WriteLine("TIPOS DE ESTADOS EN LA BASE DE DATOS");
        for (int i = 0; i < listaTiposEstados.Count; i++)
        {
            Console.WriteLine("Id: " + listaTiposEstados[i].Id + " Descripcion: " + listaTiposEstados[i].Descripcion);
        }
        Console.WriteLine("\n");


        Console.WriteLine("Prueba completada :D");
    }
}
