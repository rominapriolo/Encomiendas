using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encomiendas
{
    class Empleado
    {
        public int idEmpleado { get; set; }
        public int nroLegajo { get; set; }        
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string convenioColectivo { get; set; }
        public string categoria { get; set; }        
        public DateTime fechaIngreso { get; set; }

        //completarSolicitudServicio()
        //consultarEstadoServicio()
        //realizarPago()
        //consultarEstadoCuenta()


    }
}
