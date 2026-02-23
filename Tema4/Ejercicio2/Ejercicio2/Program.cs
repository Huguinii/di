using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacion;
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Elige el tipo de operación que quieres hacer: ");
                Console.WriteLine(" 1 - Numérica \n 2 - Logicas \n 3 - Cadenas \n 0 - Bye Bye");
                operacion = Convert.ToInt32(Console.ReadLine());

                switch (operacion)
                {
                    case 1:
                        Console.WriteLine("1 - Numérica");
                        numerica();
                        break;
                    case 2:
                        Console.WriteLine("2 - Lógicas");
                        logica();
                        break;
                    case 3:
                        Console.WriteLine("3 - Cadenas");
                        cadenas();
                        break;
                    case 0:
                        Console.WriteLine("Bye Bye");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("No se seleccionó ninugna operación");
                        break;
                }
            }
            Console.ReadKey();
        }

        public static void numerica()
        {
            float a = 0;
            float b = 0;
            Console.WriteLine("valor de a");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("valor de b");
            b = Convert.ToSingle(Console.ReadLine());
            

            Console.WriteLine("Suma: " + (a + b));

            Console.WriteLine("Resta: " + (a - b));

            Console.WriteLine("División: " + (a / b));

            Console.WriteLine("Multiplicación: " + (a * b));

            Console.WriteLine("Resto: " + (a % b));

            float resultado;
            resultado = a++;

            Console.WriteLine("Incrementar a: " + a);
            Console.WriteLine("Incrementar a: " + resultado);

            float resultado2;
            resultado2 = ++b;
            Console.WriteLine("Incrementar a: " + b);
            Console.WriteLine("Incrementar a: " + resultado2);
        }

        public static void logica()
        {
            int c = 2;
            int d = 5;

            Console.WriteLine("c es menor que d: " + (c < d));
            Console.WriteLine("c es menor igual que d: " + (c <= d));
            Console.WriteLine("c es mayor igual que d: " + (c >= d));
            Console.WriteLine("c es igual que d: " + (c == d));
            Console.WriteLine("c es distinto que d: " + (c != d));
            Console.WriteLine("c es mayor que d o c es menor que d: " + (c > d || c < d));
            Console.WriteLine("2*c es mayor que d y c es menor que d: " + (2*c > d && c < d));

        }

        public static void cadenas()
        {
            string n = "Hola";
            string m = "Buenos días";

            Console.WriteLine(n.ToUpper() + " " + m.ToLower());
            Console.WriteLine(n.Length + " " + m.Length);
            Console.WriteLine(n.Contains("a") + " " + m.Contains("b")); //m no contiene b pq es minuscula y en la cadena es mayuscula
            Console.WriteLine(n + m);
        }
    }
}