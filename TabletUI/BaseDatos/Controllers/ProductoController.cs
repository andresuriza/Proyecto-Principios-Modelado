using BaseDatos.Models;
using System;

namespace BaseDatos.Controllers;
public class ProductoController
{
    private MesContext context;
    public ProductoController() 
    { 
        this.context = new MesContext();
    }

    public List<Producto> GetAllProductos()
    {
        try
        {
            return context.Productos.ToList();
        }catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            List<Producto> vacia = null;
            return vacia;
        }
    }

    public Producto GetProductoById(int id) {
        try
        {
            return context.Productos.Find(id);
        }catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Producto vacio = null;
            return vacio;
        }
    }

    public string AddProducto(string nombre, string descripcion)
    {
        try
        {
            Producto producto1 = context.Productos.Find(nombre, descripcion);
            if(producto1 == null)
            {
                producto1 = new Producto()
                {
                    Nombre = nombre,
                    Descripcion = descripcion
                };
                context.Productos.Add(producto1);
                context.SaveChanges();
                return "Producto agregado correctamente";
            }
            else
            {
                return "Producto ya existia en la base de datos";
            }
        }catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return "Ocurrio una excepcion al intentar agregar un producto";
        }
    }

}
