using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiImplementacion.Logica
{
    public class GestorVentaEntradas
    {

        public void opcionVentaEntradas()
        {
            buscarEmpleadoLogueado();
        }
        public void buscarEmpleadoLogueado() 
        {
            //Este metodo pertenece a Sesion
            getEmpleadoEnSesion();
        }

        public void buscarSede() 
        {
            //Este metodo pertenece a Empleado
            obtenerSede();
        }

        public void buscarTarifaDeSede() 
        {
            //Este metodo pertenece a Sede
            obtenerTarifasVigentes();
        }

    }


}
