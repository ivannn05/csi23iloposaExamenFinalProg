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
    /// Implementacion encargada de contener la logica de los metodos de los ficheros
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void cargaDeDatosPorFichero()
        {
            try
            {

                string ruta = "C:\\Users\\csi23-iloposa\\Desktop\\RutaExamen\\citas.txt";
                string[] fichero = File.ReadAllLines(ruta);
                long id = 0;
                foreach (string s in fichero)
                {
                    UsuarioDto usuario = new UsuarioDto();
                    string[] campos = s.Split(';');
                    usuario.Dni = campos[0];
                    usuario.Nombre = campos[1];
                    usuario.Apellidos = campos[2];
                    usuario.Especialidad = campos[3];
                    usuario.FechaCita = Convert.ToDateTime(campos[4]);
                   
                    if (campos[5].Equals(""))
                    {
                        usuario.AsistenciaCita = false;
                    }
                    else { usuario.AsistenciaCita = Convert.ToBoolean(campos[5]); }
                    usuario.IdUsuario = id++;
                    Program.listaUsu.Add(usuario);

                }
            } catch(Exception e) { Console.WriteLine("No hay datos anteriores"); }
        }
    }
}
