using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Tema3
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)

        {
            var nombre = "";
            var edad = 0;
            Console.WriteLine("dime tu nombre");
            
            nombre = Console.ReadLine();
            Console.WriteLine(nombre);


            Console.WriteLine("dime tu edad");
            edad =int.Parse(Console.ReadLine());
            Console.WriteLine(edad);


        }
    }
}
