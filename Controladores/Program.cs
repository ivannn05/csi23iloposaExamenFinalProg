using csi23iloposaExamenFinalProg.Dtos;
using csi23iloposaExamenFinalProg.Servicios;

namespace csi23iloposaExamenFinalProg.Controladores
{
    /// <summary>
    /// Clase Main por la cual se lanzara la plicacion, y sera el inicio de esta 
    /// </summary>
    class Program
    {
        public static List<UsuarioDto> listaUsu = new List<UsuarioDto>();
        public static DateTime fecha = DateTime.Now;
        public static string ruta = $"C:\\Users\\csi23-iloposa\\Desktop\\RutaExamen\\log-{fecha.ToString("ddMMyyyy")}.txt";
        public static StreamWriter log = new StreamWriter(ruta,true);
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();
            try
            {
                fi.cargaDeDatosPorFichero();
            }catch(Exception ex) { Console.WriteLine("Ocurrio un problema en la carga del fichero"); }
            try
            {
                bool cerrarMenu = false;
                int opc;



                while (!cerrarMenu)
                {
                    opc = mi.mostrarMenuPrincipal();

                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("\tSe cerrara el menu");
                            cerrarMenu = true;
                            log.WriteLine("Se cerro el menu");
                            log.Close();
                            break;
                        case 1:
                            Console.WriteLine("\tAccedio a registro llegada");
                            log.WriteLine("Accedio a registro llegada");
                            log.Close();

                            op.validacionDNI();

                           

                            break;
                        case 2:
                            Console.WriteLine("\tAccedio a listado consultas");
                            log.WriteLine("Accedio a listado consultas");
                            log.Close();
                            mi.mostrarMenuConsultas();
                           
                            break;
                        default:
                            Console.WriteLine("\tEsta opcion no existe");
                            log.WriteLine("Accedio a Esta opcion no existe");
                            log.Close();
                            break;
                    }
                }
            }catch(Exception ex) { Console.WriteLine("Ocurrio un error en la aplicacion"); }
        }
    }
}