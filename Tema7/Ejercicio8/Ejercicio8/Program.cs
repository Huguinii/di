using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static int[] NumerosPares(int n)
        {
            int[] resultado = new int[(n / 2) + 1];
            int i = 0;
            for (int j = 0; j<= n; j++)
            {
                if ((j % 2) == 0)
                {
                    resultado[i] = j;
                    i++;
                }
            }
            return resultado;
        }
        static int[] NumerosPares()
        {
            return NumerosPares(100);
        }

        static void Main(string[] args)
        {
            //contarPares();
            Console.WriteLine("Indica una palabra a la que eliminar las vocales");
            string palabra = Console.ReadLine();
            eliminarVocales(ref palabra);
            Console.WriteLine("El resultado es " + palabra + "\n");
            Console.ReadLine();
        }

        static void eliminarVocales(ref string palabra)
        {
            string cadena = palabra.ToUpper();
            string sinvocales = "";
            for (int i = 0; i < palabra.Length; i++)
            {
                switch (cadena.Substring(i, 1))
                {
                    case "A":
                        break;

                    case "E":
                        break;

                    case "I":
                        break;

                    case "O":
                        break;

                    case "U":
                        break;

                    default:
                        sinvocales = sinvocales + palabra.Substring(i, 1);
                        break;
                }
            }
            palabra = sinvocales;
        }

        static void contarPares()
        {
            Console.WriteLine("Indica hasta que numero quieres obtener numeros pares ");
            int resp = Convert.ToInt32((Console.ReadLine()));
            int[] pares = NumerosPares();
            string salida;
            pares = NumerosPares(resp);
            Console.WriteLine("La relacion de numeros pares hasta {0} es: " + "\n", resp);
            salida = "(" + pares[0];
            for (int i = 1; i < pares.Length; i++)
            {
                salida = salida + "," + pares[i];
            }
            salida = salida + ")";
            Console.WriteLine(salida + "\n\n");
        }
    }
}
