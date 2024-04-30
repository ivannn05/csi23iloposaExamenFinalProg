using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23iloposaExamenFinalProg.Servicios
{
    /// <summary>
    /// Interfaz encargada de contener las cabeceras de los metodos de la app
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de la existencia del DNI
        /// </summary>
        /// <returns></returns>
        public bool validacionDNI();
    }
}
