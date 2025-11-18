using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un valor: ");
            var valor = Console.ReadLine();
            if (int.Parse(valor) < 0)
            {
                Console.WriteLine("Es negativo");
            }
            else
            {
                Console.WriteLine("Es positivo");
            }
        }
    }
}
