using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjerciciosPractica2.Clases;

namespace EjerciciosPractica2.Clases
{
    class cMenu
    {
        public void mostrar()
        {
            string opcion = "";

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine("                                     UNIVERSIDAD AUTONOMA DE SANTO DOMINGO      ");
                Console.WriteLine("                                                     UASD      ");
                Console.WriteLine("                                              FACULTAD DE CIENCIAS      ");
                Console.WriteLine("                                             ESCUELA DE INFORMATICA     ");

                Console.WriteLine("                                               PRACTICA NUMERO II      ");
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine();


                Console.WriteLine("**************** ELIJA UNA OPCION DEL SIGUIENTE MENU *********************");
                Console.WriteLine("1 - Imprimir Multiplos De 3 Del 1 al 200 (Ejercicio 1).");
                Console.WriteLine("2 - Imprimir Datos De Operario (Ejercicio 2).");
                Console.WriteLine("3 - Imprimir Numeros Positivos, Negativos, Pares e Impares (Ejercicio 3).");
                Console.WriteLine("4 - Datos De Cuentas Corrientes (Ejercicio 4).");
                Console.WriteLine("S - Presione la tecla 'S' para salir");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine();
                Console.Write("Seleccione Una Opcion: ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        cUtilidades.MultiplosTres();
                        break;
                    case "2":
                        cUtilidades.CalcularSalarioEmpleado();
                        break;
                    case "3":
                        cUtilidades.ImprimirNumeros();
                        break;

                    case "4":
                        cUtilidades.CuentasCorrientes();
                        break;

                    default:
                        Console.WriteLine("<<<<<<<<<<< Hasta pronto!!! >>>>>>>>>>");
                        opcion = "s";
                        break;
                }

            } while (opcion != "s" & opcion != "S");

            Console.ReadKey();

        }
    }
}
