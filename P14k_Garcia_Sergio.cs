// Alumno: García Barrera, Sergio

using System;

namespace P14k_Garcia_Sergio // Note: Nombre actual del proyecto
{
    internal class P14k_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            Random random = new Random();           // Generador random
            int limiteMinimo = random.Next(100);        // El minimo es 0 por tanto solo establezco el máximo, el 100 no se incluye
            int limiteMaximo = random.Next(300, 501);
            const int COLUMNAS = 5;
            int mayor = 0;
            int menor = 99;

            Console.WriteLine("\n Dos números menores de 100 aleatorio y entre 300 y 500");
            for (int i = 0; i < 2; i++)
            {
                limiteMinimo = random.Next(100);
                limiteMaximo = random.Next(300, 500 + 1);
                Console.Write(limiteMinimo);
                Console.WriteLine(" y {0}", limiteMaximo);
            }

            Console.Write("\n 50 valores tomados al azar entre limiteMinimo y limiteMaximo, ambos incluidos.");
            for (int i = 0; i < 50; i++)
            {
                // Preparar en columas
                if (i++ % COLUMNAS == 0)
                    Console.WriteLine();

                limiteMinimo = random.Next(100);
                limiteMaximo = random.Next(300, 500 + 1);
                Console.Write("\t " + limiteMinimo + " | " + limiteMaximo); 
                // VA CAMBIANDO EL Numero más grade que va generando por la variable Mayor y asigna su valor
                if (limiteMaximo > mayor)
                {
                    mayor = limiteMaximo;
                }

                // VA CAMBIANDO EL Numero más pequeño que va generando por la variable Menor y asigna su valor
                if (limiteMinimo < menor)
                {
                    menor = limiteMinimo;
                }
            }

            Console.Write("\nEl valor máximo ha sido {0} y el menor {1}", mayor, menor);
            Console.ReadLine();
        }
    }
}