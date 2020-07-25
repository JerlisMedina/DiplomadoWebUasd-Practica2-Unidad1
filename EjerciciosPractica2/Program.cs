using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjerciciosPractica2.Clases;

namespace EjerciciosPractica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            cMenu menu = new cMenu();
            menu.mostrar();
        }
    }
}
