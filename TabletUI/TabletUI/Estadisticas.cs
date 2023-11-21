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

        public static TimeSpan Break(string cedula, TimeOnly currTime)
        {
            return currTime - usrPerLinea.GetDelays(cedula) - (usrPerLinea.GetUsuarioTime(cedula) - new TimeOnly(0, 0));
        }

        public static void RunStats() // Metodo que las clases llaman al cerrarse
        {
            GetEmpleadoTimes();
            GetLoteTimes();
        }

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

        public static void GetLoteTimes() // Metodo que las clases llaman al cerrarse
        {
            TimeOnly currTime = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute);

            string[] loteStats;

            loteStats = new string[] {"Lote,Descripcion,ID Producto,Cantidad Obtenida,Inicio,Setup,Envasado,Etiquetado" +
                ",Sellado,Finalizacion,Fin"};

            File.WriteAllLines("Lotes.csv", loteStats);

            foreach (var lote in lotControllerLinea.GetAllLotesPorLineas())
            {
                Lote loteEspecifico = lotController.GetLoteById(lote.Loteid);

                if (loteEspecifico.Estado == 3)
                {
                    TimeOnly pastTime = lotControllerLinea.GetLoteTime(lote.Loteid);
                    TimeSpan elapsedTime = currTime - pastTime;

                    loteStats = new string[] {loteEspecifico.Id + "," + loteEspecifico.Descripcion + "," + 
                        loteEspecifico.Productoid + "," + loteEspecifico.Cantidadrequerida + "," + lote.Horainicio + "," + 
                        elapsedTime * 0.6 + "," + elapsedTime * 0.1 + "," + elapsedTime * 0.05 + "," + elapsedTime * 0.05 + 
                        "," + elapsedTime * 0.2 + "," + currTime};

                    File.AppendAllLines("Lotes.csv", loteStats);
                }
            }
        }
    }
}
