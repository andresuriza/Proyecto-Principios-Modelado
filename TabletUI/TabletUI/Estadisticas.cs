using BaseDatos.Controllers;
using BaseDatos.Models;
using System.Diagnostics;
using System.Windows.Forms;

namespace TabletUI
{
   public static class Estadisticas
    {
        private static UsuarioPorLineaController usrPerLinea = new UsuarioPorLineaController();
        private static UsuarioController uc = new UsuarioController();
        private static LotePorLineaController lotControllerLinea = new LotePorLineaController();
        private static LoteController lotController = new LoteController();
        private static LineaController lineaController = new LineaController();

        // Metodo que calcula el tiempo trabajado por un empleado
        public static TimeSpan Break(string cedula, TimeOnly currTime)
        {
            return currTime - usrPerLinea.GetDelays(cedula) - (usrPerLinea.GetUsuarioTime(cedula) - new TimeOnly(0, 0));
        }

        // Llama los metodos para crear archivos .csv que las clases llaman al cerrarse
        public static void RunStats() 
        {
            GetEmpleadoTimes();
            GetLoteTimes();
            GetMaquinas();
        }

        // Metodo que calcula el tiempo trabajado por un empleado y lo guarda en un archivo .csv
        public static void GetEmpleadoTimes()
        {
            TimeOnly currTime = new TimeOnly(17, 0);

            string[] empleadoStats;

            empleadoStats = new string[] { "Empleados,Horas laboradas" };

            File.WriteAllLines("Empleados.csv", empleadoStats);

            foreach (var empleadoLista in usrPerLinea.GetAllUsuarios())
            {
                Usuario empleado = uc.GetUsuarioByCedula(empleadoLista.Cedula);

                empleadoStats = new string[] { empleado.Cedula + "," + Break(empleado.Cedula, currTime) };
                File.AppendAllLines("Empleados.csv", empleadoStats);
            } 
        }

        // Metodo que calcula el tiempo empleado en cada etapa de produccion de un lote y lo guarda en un archivo .csv
        public static void GetLoteTimes() 
        {
            TimeOnly currTime = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute);

            string[] loteStats;

            loteStats = new string[] {"Lote,Descripcion,ID Producto,Cantidad Obtenida,Inicio,Setup,Envasado,Etiquetado" +
                ",Sellado,Finalizacion,Fin"};

            File.WriteAllLines("Lotes.csv", loteStats);

            foreach (var lote in lotControllerLinea.GetAllLotesPorLineas())
            {
                Lote loteEspecifico = lotController.GetLoteById(lote.Loteid);
                TimeOnly pastTime = lotControllerLinea.GetLoteTime(lote.Loteid);
                TimeSpan elapsedTime = currTime - pastTime;

                if (loteEspecifico.Estado == 3)
                {
                    loteStats = new string[] {loteEspecifico.Id + "," + loteEspecifico.Descripcion + "," + 
                        loteEspecifico.Productoid + "," + loteEspecifico.Cantidadrequerida + "," + lote.Horainicio + "," + 
                        elapsedTime * 0.6 + "," + elapsedTime * 0.1 + "," + elapsedTime * 0.05 + "," + elapsedTime * 0.05 + 
                        "," + elapsedTime * 0.2 + "," + currTime};   
                }
                else
                {
                    Random rnd = new Random();
                    loteStats = new string[] {loteEspecifico.Id + "," + loteEspecifico.Descripcion + "," +
                        loteEspecifico.Productoid + "," + rnd.Next(0, loteEspecifico.Cantidadrequerida) + "," + lote.Horainicio + "," +
                        "Sin finalizar,Sin finalizar,Sin finalizar,Sin finalizar,Sin finalizar,Sin finalizar"};
                }
                File.AppendAllLines("Lotes.csv", loteStats);
            }
        }

        // Metodo que obtiene las maquinas en cada linea y su estado y lo guarda en un archivo .csv
        public static void GetMaquinas()
        {
            string[] maquinas;
            maquinas = new string[] {"Linea,Estado de maquinaria"};

            File.WriteAllLines("Maquinas.csv", maquinas);

            foreach (var lineas in lineaController.GetAllLineas())
            {
                if (lineas.Estadoid == 1)
                {
                    maquinas = new string[] {lineas.Id + ",Funcionando"};
                }

                else if (lineas.Estadoid == 2)
                {
                    maquinas = new string[] {lineas.Id + ",Con fallos" };
                }

                File.AppendAllLines("Maquinas.csv", maquinas);
            }
        }
    }
}
