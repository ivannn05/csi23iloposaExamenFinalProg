using csi23iloposaExamenFinalProg.Controladores;
using csi23iloposaExamenFinalProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23iloposaExamenFinalProg.Servicios
{
    /// <summary>
    /// Clase la cual contiene los datos de los metodos del menu
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMenuConsultas()
        {
            bool cerrarMenuConsultas = false;
            int opc;


            while (!cerrarMenuConsultas)
            {
                Console.WriteLine("######################################");
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("0.Cerrar menu");
                Console.WriteLine("1.Mostrar consultas");
                Console.WriteLine("2.Imprimir consultas");
                Console.WriteLine("######################################");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        Console.WriteLine("\tSe cerrara el menu");
                        cerrarMenuConsultas = true;
                        break;
                    case 1:
                        Console.WriteLine("\tAccedio a Mostrar consultas");
                        mostrarEspecialidadConsultas();
                        foreach (UsuarioDto item in Program.listaUsu)
                        {
                            Console.WriteLine(string.Concat("Nombre completo:",item.Nombre,item.Apellidos,item.FechaCita.Hour,":", item.FechaCita.Minute));
                        }
                        break;
                    case 2:
                        Console.WriteLine("\tAccedio a Imprimir consultas");

                        break;
                    default:
                        Console.WriteLine("\tEsta opcion no existe");
                        break;
                }
            }
          
        }
        /// <summary>
        /// Metodo privado que acompaña al menu de consultas,que controla la entrada a las especialidades
        /// </summary>
        private void mostrarEspecialidadConsultas()
        {
            bool cerrarMenuEspecialidadesConsultas = false;
            int opc;

            Console.WriteLine("######################################");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Psicología");
            Console.WriteLine("2.Traumatología");
            Console.WriteLine("3.Fsioterapia");
            Console.WriteLine("######################################");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 0:
                    Console.WriteLine("\tSe cerrara el menu");
                    cerrarMenuEspecialidadesConsultas = true;
                    break;
                case 1:
                    Console.WriteLine("\tAccedio a Psicología");
                   
                    break;
                case 2:
                    Console.WriteLine("\tAccedio a Traumatología");

                    break;
                case 3:
                    Console.WriteLine("\tAccedio a Fsioterapia");

                    break;
                default:
                    Console.WriteLine("\tEsta opcion no existe");
                    break;
            }
        }

    

        public int mostrarMenuPrincipal()
        {
            int opc;
            Console.WriteLine("######################################");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Registro de llegada");
            Console.WriteLine("2.Listado consultas");
            Console.WriteLine("######################################");
            opc =Convert.ToInt32(Console.ReadLine());

            return opc;
        }
    }
}
