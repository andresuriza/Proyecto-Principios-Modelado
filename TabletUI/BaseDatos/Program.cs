using BaseDatos.Controllers;
using BaseDatos.Models;
public class Program
{
    public static void Main(string[] args)
    {
        UsuarioController uc = new UsuarioController();
        string res = uc.AddUsuario("123456789", "Tanenbaum", "Arias", "Alfaro", "1111", 1);
        List<Usuario> listaUsers = uc.GetAllUsuarios();
        Console.WriteLine("\n");

    }
}
