using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    abstract class Test
    {
        public int a = 10;
        public abstract void A();

    }

    class Ejemplo1 : Test
    {
        public override void A()
        {
            Console.WriteLine("Ejemplo1.A");
            base.a++;
        }
    }

    class Ejemplo2 : Test
    {
        public override void A()
        {
            Console.WriteLine("Ejemplo2.A");
            base.a--;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Test test1 = new Ejemplo1();
                Console.WriteLine(test1.a);
                test1.A();
                Console.WriteLine(test1.a);
                

                Test test2 = new Ejemplo2();
                Console.WriteLine(test2.a);
                test2.A();
                Console.WriteLine(test2.a);
            }
        }
    }

    
}