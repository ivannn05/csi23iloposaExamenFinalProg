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
    /// Metodo el cual contiene el funcionamiento de los metodos de la app
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public bool validacionDNI()
        {
            
                bool validacion = false;
                do
                {

                    Console.WriteLine("Escriba su DNI");
                    string dniUsu = Console.ReadLine();






                    char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };



                    int numeroDigitos = dniUsu.Length - 1;

                    int numerosDni = Convert.ToInt32(dniUsu.Substring(0, numeroDigitos));

                    int validad = numerosDni % 23;

                    char posicion = letras[validad];
                    char letraValidacion = Convert.ToChar(letras[validad]);

                    char letraDni = dniUsu[numeroDigitos];

             
                    if (letraDni.Equals(posicion))
                    {
                        validacion = true;
                    }




                    if (validacion == false)
                    {
                        Console.WriteLine("El DNI no es correcto");
                    }
                    else
                    {
                        foreach (UsuarioDto usu in Program.listaUsu)
                        {

                            if (dniUsu.Equals(usu.Dni) & validacion == true)
                            {
                                if (usu.AsistenciaCita == true)
                                {
                                    Console.WriteLine(" Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.\n");
                                }
                                else { Console.WriteLine(" No dispone de cita previa para hoy.\n"); }
                            }

                        }


                    }
                } while (validacion = false);

            
            return validacion;
            
        }
    }
}
