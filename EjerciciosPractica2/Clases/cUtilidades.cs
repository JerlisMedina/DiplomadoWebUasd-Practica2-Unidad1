using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosPractica2.Clases
{
    class cUtilidades
    {
        public static void MultiplosTres()
        {
            int i = 1;
            const int limite = 200;

            Console.WriteLine();
            Console.WriteLine("                     ========================== IMPRIMIR MULTIPLOS DE 3 DEL 1 AL 200 ==========================");
            Console.WriteLine();


            Console.WriteLine("                                  Multiplos de 3: ");

            while (i <= limite)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CalcularMasaAire()
        {
            double presion = 0, volumen = 0, temperatura = 0, masa = 0;
            const double vValor = 0.37, vValor2 = 460;

            Console.WriteLine();
            Console.WriteLine("                     ========================== CALCULAR LA MASA DE AIRE ==========================");
            Console.WriteLine();


            Console.Write("                                   Presión: ");
            presion = double.Parse(Console.ReadLine());

            Console.Write("                                   Volumen: ");
            volumen = double.Parse(Console.ReadLine());

            Console.Write("                                   Temperatura: ");
            temperatura = double.Parse(Console.ReadLine());

            masa = Math.Round((presion * volumen) / (vValor * (temperatura + vValor2)), 2);

            Console.WriteLine();
            Console.WriteLine($"                                 La masa es: {masa}");
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CalcularSalarioEmpleado()
        {
            string nombre = "", puesto = "";
            double sueldo = 0, antiguedad = 0, aumento = 0;
            const double porciento20 = 0.20, porciento5 = 0.05;

            Console.WriteLine();
            Console.WriteLine("                     ========================== DATOS DEL OPERARIO ==========================");
            Console.WriteLine();


            Console.Write("                                   Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("                                   Puesto: ");
            puesto = Console.ReadLine();

            Console.Write("                                   Años Laborando (Antiguedad): ");
            antiguedad = double.Parse(Console.ReadLine());

            Console.Write("                                   Sueldo: ");
            sueldo = double.Parse(Console.ReadLine());

            if (sueldo >= 500)
            {
                Console.WriteLine();
                Console.WriteLine($"                               Sueldo a pagar: {sueldo}");
            }
            else
            {
                if (antiguedad >= 10)
                {
                    aumento = Math.Round((sueldo * porciento20),2);
                    sueldo += aumento;
                    Console.WriteLine();
                    Console.WriteLine($"                               Aumento de 20%: {aumento}");
                    Console.WriteLine($"                               Sueldo a pagar: {sueldo}");
                }
                else
                {
                    aumento = Math.Round((sueldo * porciento5), 2);
                    sueldo += aumento;
                    Console.WriteLine();
                    Console.WriteLine($"                               Aumento de 5%: {aumento}");
                    Console.WriteLine($"                               Sueldo a pagar: {sueldo}");
                }
            }

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void ImprimirNumeros()
        {
            int positivos = 0, negativos = 0, pares = 0, impares = 0;
            int numeros, n = 0, i = 1;

            Console.WriteLine();
            Console.WriteLine("                     =================== IMPRIMIR NUMEROS PARES, IMPARES, POSITIVOS Y NEGATIVOS ===================");
            Console.WriteLine();

            Console.Write("                                   Cuántos números desea imprimir: ");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                Console.Write($"                                     Valor numero {i}: ");
                numeros = int.Parse(Console.ReadLine());

                if (numeros % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (numeros < 0)
                {
                    negativos++;
                }
                else
                {
                    positivos++;
                }

                i++;
            }

            Console.WriteLine();
            Console.WriteLine($"                    Total Pares = {pares} Total Impares = {impares} Total Positivos: {positivos} Total Negativos: {negativos}");

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CuentasCorrientes()
        {
            double saldoActual = 0, totalAcreedores = 0, totalDeudores = 0;
            int numeroCuenta = 0;
            string estadoCuenta = "";

            Console.WriteLine();
            Console.WriteLine("                     ==================== DATOS CUENTAS CORRIENTES CLIENTES BANCARIOS ====================");
            Console.WriteLine();

            //Console.Write("                                   Numero de cuenta: ");
            //numeroCuenta = int.Parse(Console.ReadLine());

            //Console.Write("                                   Saldo actual: ");
            //saldoActual = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("                                   Numero de cuenta: ");
                numeroCuenta = int.Parse(Console.ReadLine());

                Console.Write("                                   Saldo actual: ");
                saldoActual = double.Parse(Console.ReadLine());

                if (saldoActual > 0)
                {
                    estadoCuenta = "Acreedor";
                    totalAcreedores += saldoActual;
                }
                else
                {
                    estadoCuenta = "Deudor";
                    totalDeudores += saldoActual;
                }

                if (saldoActual == 0)
                {
                    estadoCuenta = "Nulo";
                }

                Console.WriteLine();
                Console.WriteLine($"                                   Cuenta: {numeroCuenta}");
                Console.WriteLine($"                                   Estado: {estadoCuenta}");
                Console.WriteLine($"                                   Total Acreedores: {totalAcreedores}");
                Console.WriteLine($"                                   Total Deudores: {totalDeudores}");
                Console.WriteLine();

            } while (numeroCuenta >= 0);

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
