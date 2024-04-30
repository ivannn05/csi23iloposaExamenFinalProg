
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23iloposaExamenFinalProg.Servicios
{/// <summary>
/// Clase interfaz la cual contendra la cabecera de los metodos encargados de los menus
/// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar el menu principal
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuPrincipal();
        /// <summary>
        /// Metodo encargargado de llevar el funcionamiento del menu de consultas
        /// </summary>
        public void mostrarMenuConsultas();
        

    }
}
