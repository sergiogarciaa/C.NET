using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14j_Garcia_Sergio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int limiteMinimo = random.Next(100);
            int limiteMaximo = random.Next(300, 501);
            //const int COLUMNAS = 5;
            int mayor = 0;
            int menor = 99;
            int num;
            int posMax=0;
            int posMin=0;


            num = random.Next(limiteMinimo, limiteMaximo);
            menor = mayor = num;
            Console.WriteLine("\n 50 valores tomados al azar entre limiteMinimo y limiteMaximo, ambos incluidos.");
            for (int i = 1; i <= 50; i++)
            {
                //if (i++ % COLUMNAS == 0)
                //    Console.WriteLine();
                if (i < 10)
                    Console.Write(" ");

                num = random.Next(limiteMinimo, limiteMaximo);
                Console.WriteLine("{0}) {1}", i, num);
                if (num > mayor)
                {
                    mayor = num;
                    posMax = i;
                }

                // VA CAMBIANDO EL Numero más pequeño que va generando por la variable Menor y asigna su valor
                else if (num < menor)
                {
                    menor = num;
                    posMin = i;
                }
            }

            Console.Write("\nEl valor máximo ha sido {0} y está en la posición {1}", mayor, posMax);
            Console.WriteLine("\nEl valor mínimo ha sido {0} y está en la posición {1}", menor, posMin);
            Console.ReadLine();
        }
    }
}
