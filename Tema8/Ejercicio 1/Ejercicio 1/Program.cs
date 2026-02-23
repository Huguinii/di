using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class RestarArray
    {
        int[] Z;
        int[] K;
        int[] J;
        int[] H;

        static void Main(string[] args)
        {
            RestarArray c = new RestarArray();
            c.Cargar();
            c.Visualizar();
        }

        public void Cargar()
        {
            Console.Write("Inserte la longitud de los arrays a restar y sumar: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            Z = new int[n];
            K = new int[n];
            J = new int[n];
            H = new int[n];
            Console.WriteLine("Introduciendo los valores en el array Z");
            for (int i = 0; i < Z.Length; i++)
            {
                Console.WriteLine("Introduzca componente[ " + (i + 1) + "]: ");
                linea = Console.ReadLine();
                Z[i] = int.Parse(linea);
            }
            Console.WriteLine("Introduciendo los valores en el array K");
            for (int j = 0; j < K.Length; j++)
            {
                Console.WriteLine("Introduzca componente[ " + (j + 1) + "]: ");
                linea = Console.ReadLine();
                K[j] = int.Parse(linea);
            }
            Console.WriteLine("Introduciendo los valores en el array J");
            for (int z = 0; z < J.Length; z++)
            {
                Console.WriteLine("Introduzca componente[ " + (z + 1) + "]: ");
                linea = Console.ReadLine();
                J[z] = int.Parse(linea);
            }
            for (int i = 0; i < Z.Length; i++)
            {
                H[i] = K[i] - Z[i] + J[i];
            }
        }

        public void Visualizar()
        {
            Console.WriteLine("La suma y resta de los arrays es : ");
            for (int i = 0; i < Z.Length; i++)
            {
                Console.WriteLine("[" + H[i] + "]");
            }
            Console.ReadLine();
        }
    }
}
