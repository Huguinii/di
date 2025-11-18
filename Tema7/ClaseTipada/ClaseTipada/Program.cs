using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            Contenedor<int> v_contenedor = new Contenedor<int>(5, "Mi Contenedor", 100);
            Console.WriteLine(v_contenedor.ToString() + "\n");

        }

        class Contenedor<T> {

    }
}
