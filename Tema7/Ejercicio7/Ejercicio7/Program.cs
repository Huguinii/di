using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CocheElectrico coche1 = new CocheElectrico(50, "123456", "Volvo", 500);
            coche1.Acelerar(out int velocidad);
            Console.WriteLine("Aceleramos a velocidad de " + velocidad 
                + " y la carga actual es " + coche1.carga + "\n");
            coche1.Acelerar(out int velocidad1);
            Console.WriteLine("Aceleramos de nuevo, a velocidad de " + velocidad1
                + " y la carga actual es " + coche1.carga + "\n");
            Console.WriteLine("Indica la cantidad que quieres frenar");
            int p_cantidad = Convert.ToInt32(Console.ReadLine());
            coche1.Frenar(p_cantidad, out int velocidad2);
            Console.WriteLine("Frenamos a " + velocidad2 + " y la carga actual es " + coche1.carga + "\n");
            */
            CocheElectrico coche2 = new CocheElectrico(100, "COCHE2", "Audi", 200, "Ana", 2020);
            coche2.MostrarDueño();
            coche2.AñosPertenencia();
        }
        public interface IVehiculoPropio
        {
            void MostrarDueño();
            void AñosPertenencia();
        }
        class Coche
        {
            protected string matricula;
            protected string marca;
            protected int caballos;
            protected int velocidad;
            protected string dueño;
            protected int añoAdquisicion;
            public Coche(string p_matricula, string p_marca, int p_caballos, string p_dueño, int p_año)
            {
                this.matricula = p_matricula;
                this.marca = p_marca;
                this.caballos = p_caballos;
                this.dueño = p_dueño;
                this.añoAdquisicion = p_año;
            }

            public virtual void Acelerar(out int p_velocidad)
            {
                if (this.velocidad < 160)
                {
                    this.velocidad = this.velocidad + 40;
                }
                p_velocidad = this.velocidad;
            }

            public virtual void Frenar(int p_cantidad, out int p_velocidad)
            {
                if ((this.velocidad > 0) && (this.velocidad - p_cantidad > 0))
                {
                    this.velocidad = this.velocidad - p_cantidad;
                }
                else
                {
                    this.velocidad = 0;
                }
                p_velocidad = this.velocidad;
            }
        }

        class CocheElectrico : Coche, IVehiculoPropio
        {
            public int carga;
            public CocheElectrico(int carga, string matricula, string marca, int caballos, string dueño, int año) 
                : base(matricula, marca, caballos, dueño, año)
            {
                this.carga = carga;
            }
            public string GetDueño()
            {
                return this.dueño;
            }
            public int GetAñoAdquisicion()
            {
                return this.añoAdquisicion;
            }

            public void MostrarDueño()
            {
                Console.WriteLine("El dueño de este coche es " + this.GetDueño() + "\n");
            }

            public void AñosPertenencia()
            {
                DateTime fecha_hoy = DateTime.Now;
                int añoActual = fecha_hoy.Year;

                Console.WriteLine("Este coche pertenece " + (añoActual - this.GetAñoAdquisicion()) +
                    " años a su dueño " + this.GetDueño() + "\n");
            }


            public override void Acelerar(out int p_velocidad)
            {
                if (this.carga > 0)
                {
                    base.Acelerar(out p_velocidad);
                    if(this.carga - 20 > 0)
                    {
                        this.carga = this.carga - 20;
                    }
                    else
                    {
                        this.carga = 0;
                    }
                }
                else
                {
                    p_velocidad = this.velocidad;
                }
                
            }

            public override void Frenar(int p_cantidad, out int p_velocidad)
            {
                if(this.velocidad > 0)
                {
                    int velocidad = this.velocidad;
                    base.Frenar(40, out p_velocidad);
                    if ((p_velocidad != velocidad) && (this.carga + 10 <= 100))
                    {
                        this.carga = this.carga + 10;
                    }
                    
                }
                else
                {
                    p_velocidad = this.velocidad;
                }
            }
        }
        
    }
}

