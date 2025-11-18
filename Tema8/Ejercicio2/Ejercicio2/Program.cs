using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class SumaMatriz
    {
        private int[,] MatrizA;
        private int[,] MatrizB;
        private int[,] MatrizC;
        static void Main(string[] args)
        {
            SumaMatriz sm = new SumaMatriz();
            sm.Cargar();
            sm.Visualizar();
        }

        public void Cargar()
        {
            MatrizA = new int[10, 10];
            MatrizB = new int[10, 10];
            MatrizC = new int[10, 10];

            Console.WriteLine("Introduciendo datos en la matriz A");
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <=3; j++)
                {
                    Console.Write("Introduzca posicion[" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizA[i, j] = int.Parse(linea);
                }
            }
            Console.WriteLine("Introduciendo datos en la matriz B");
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write("Introduzca posicion[" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizB[i, j] = int.Parse(linea);
                }
            }

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] + MatrizB[i, j];
                }
            }

        }
        public void Visualizar()
        {
            Console.WriteLine("La suma de la matrizA y matrizB es: ");
            for (int i = 0; i <= 3; i++)
            {
                Console.Write("\n");
                for (int j = 0;j <= 3; j++)
                {
                    Console.Write(MatrizC[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
    }

    
}
