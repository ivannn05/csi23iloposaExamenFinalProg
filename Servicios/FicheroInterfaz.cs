using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23iloposaExamenFinalProg.Servicios
{
    /// <summary>
    /// Clase encargada de contener las cabecersa de los metodos de fichero
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo el cual se encargara de cargar la lista de usuarios con los datos del fichero
        /// </summary>
        public void cargaDeDatosPorFichero();
    }
}
