using BaseDatos.Controllers;
using BaseDatos.Models;
using BaseDatos.Controllers;
using BaseDatos.Models;

public class Program
{
    public static void Main(string[] args)
    {

        UsuarioController uc = new UsuarioController();
        LineaController lc = new LineaController();
        TipoUsuarioController tuc = new TipoUsuarioController();
        TipoEstadoController tec = new TipoEstadoController();
        LoteController loteC = new LoteController();
        UsuarioPorLineaController usrPerLine = new UsuarioPorLineaController();

        // ESTOS METODOS AGARRAN LOS DATOS DESDE LA BASE DE DATOS


        List<Usuario> listaUsers = uc.GetAllUsuarios();
        List<Linea> listaLineas = lc.GetAllLineas();
        List<TipoUsuario> listaTiposUsuarios = tuc.GetAllTiposUsuarios();
        List<TipoEstado> listaTiposEstados = tec.GetAllTiposEstados();
        List<Lote> listaLotes = loteC.GetAllLotes();
        List<UsuarioPorLinea> listaUsersPorL = usrPerLine.GetAllUsuarios();


        // IMPRESION DE LOS DATOS EN CONSOLA

        Console.WriteLine("USUARIOS EN LA BASE DE DATOS");
        //uc.AddUsuario("118891234", "Rene", "Amancio", "Melendez", "1234", 1, 0);
        //uc.AddUsuario("118891235", "Tanenbaum", "Arias", "Alfaro", "1235", 1, 0);
        //uc.AddUsuario("118891236", "Carmelita", "Fausto", "Severiano", "1236", 1, 0);
        //uc.AddUsuario("118891237", "Cristobal", "Domingo", "Alba", "1237", 2, 0);
        //uc.AddUsuario("118891238", "Nereida", "Yurena", "Vargas", "1238", 1, 0);
        //uc.AddUsuario("118891239", "Abundio", "Arleth", "Renato", "1239", 1, 0);
        //uc.AddUsuario("118891240", "Adolfito", "Antelmo", "Rodriguez", "1240", 1, 0);
        //uc.AddUsuario("118891241", "Hermes", "Renata", "Febe", "1241", 1, 0);
        //uc.AddUsuario("118891242", "David", "Canas", "Figueres", "1242", 1, 0);
        //uc.AddUsuario("118891243", "Juliana", "Granados", "Lopez", "1243", 1, 0);

        for (int i = 0; i < listaUsers.Count; i++)
        {
            Console.WriteLine("Cedula: " + listaUsers[i].Cedula +
                                " Nombre: " + listaUsers[i].Nombre +
                                " Apell1: " + listaUsers[i].Apellido1 +
                                " Apell2: " + listaUsers[i].Apellido2 +
                                " Codigo: " + listaUsers[i].Codigo +
                                " TipoUsuarioId: " + listaUsers[i].Tipousuarioid +
                                " EstaEnBreak: " + listaUsers[i].Estaenbreak);
        }
        Console.WriteLine("\n");

        Console.WriteLine("USUARIOS EN CADA LISTA");
        //Console.WriteLine(res);
        for (int i = 0; i < listaUsersPorL.Count; i++)
        {
            Console.WriteLine("Cedula: " + listaUsersPorL[i].Cedula +
                                " ID linea: " + listaUsersPorL[i].Lineaid +
                                " Fecha: " + listaUsersPorL[i].Fecha +
                                " Hora inicio: " + listaUsersPorL[i].Horainicio +
                                " Hora final: " + listaUsersPorL[i].Horafinal);
        }
        Console.WriteLine("\n");


        Console.WriteLine("LINEAS EN LA BASE DE DATOS");
        for (int i = 0; i < listaLineas.Count; i++)
        {
            Console.WriteLine("Id: " + listaLineas[i].Id + " Estado: " + listaLineas[i].Estadoid);
        }
        Console.WriteLine("\n");

        Console.WriteLine("TIPOS DE USUARIOS EN LA BASE DE DATOS");
        for (int i = 0; i < listaTiposUsuarios.Count; i++)
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

        Console.WriteLine("LOTES EN LA BASE DE DATOS");
        for (int i = 0; i < listaLotes.Count; i++)
        {
            Console.WriteLine("Id: " + listaLotes[i].Id +
                                " Descripcion: " + listaLotes[i].Descripcion +
                                " ProductoId: " + listaLotes[i].Productoid +
                                " Cant.Esperada: " + listaLotes[i].Cantidadrequerida +
                                " Cant.Obtenida de momento: " + listaLotes[i].Cantidadobtenida +
                                " Estado: " + listaLotes[i].Estado);
        }

        Console.WriteLine("\n");

    }
}