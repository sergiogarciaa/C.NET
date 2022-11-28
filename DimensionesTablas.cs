using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de un array 3x5 
            int[,] a2D = new int[3, 5];
            // Declaracion y construcción
            int[,] tabla2D = { {1, 3, 5, 7, 9},
                               {2, 4, 6, 8, 10},
                               {11,12,13,14,15} };

             // GetLenght(0) es el primer valor, en este caso 3. GetLenght(1) es el segundo valor, en este caso
            //
           //                                                     Tamaño total       Primera dimension    Segunda dimension
            Console.WriteLine("Tamaño total = {0}; en {1} x {2}", tabla2D.Length, tabla2D.GetLength(0), tabla2D.GetLength(1));

            Console.WriteLine("Mostrar todos los elementos pero usando los limites genéricos");

            //Por cada fila recorre todas sus columnas
            for(int i = 0; i<tabla2D.GetLength(0); i++) //Recorriendo la fila
            {
                for(int j = 0; j < tabla2D.GetLength(1); j++) // Recorriendo las columnas
                {
                    Console.Write("\t{0}", tabla2D[i,j]);
                }
                Console.WriteLine("\n");
            }


            Console.WriteLine("\nMostrando solo los 4 primeros elementos de las dos primeras filas");

            for(int i = 0; i<2; i++) // i<2 prq son solo las dos primeras filas
            {
               for(int j = 0; j<4; j++) // Menor que 4 prq son los 4 elementos
                {
                    Console.Write("\t {0}", tabla2D[i,j]);
                }
               Console.WriteLine("\n");
            }

            int fila = CapturaEntero("Qué fila quieres leer?", 0, tabla2D.GetLength(0)-1);
            Console.WriteLine("\n\n\tMostrando la fila elegida \n");

            for(int i =0; i<tabla2D.GetLength(1); i++)
            {
                Console.Write("\t {0}",tabla2D[fila, i]);
            }

            int col = CapturaEntero("\nQué columna quieres leer?", 0, tabla2D.GetLength(0));
            Console.WriteLine("Mostrar los elementos de la columna elegida");
            for(int i = 0; i < tabla2D.GetLength(0); i++)
            {
                Console.WriteLine("\t {0}", tabla2D[i,col]);
            }

            Console.WriteLine("Mostrar el elemento de la fila y columna");
            Console.WriteLine("\t {0}", tabla2D[fila, col]);

            Console.WriteLine("Asignar un valor a la posición de la fila y la columna elegida");
            tabla2D[fila, col] = CapturaEntero(String.Format("Nuevo valor de la posición ({0}, {1})", fila, col), -100, 100);

            for (int i = 0; i < tabla2D.GetLength(0); i++) //Recorriendo la fila
            {
                for (int j = 0; j < tabla2D.GetLength(1); j++) // Recorriendo las columnas
                {
                    Console.Write("\t{0}", tabla2D[i, j]);
                }
                Console.WriteLine("\n");
            }

            Console.Write("\n\nPulsa una tecla para salir");
            Console.ReadKey(true);
        }

        private static int CapturaEntero(string texto, int min, int max)
        {
            bool esCorrecto;
            int valor;
            do
            {
                Console.Write("{0} [{1}..{2}]: ", texto, min, max);

                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto)
                    Console.WriteLine("\n\n\t** Error: el valor introducido no es un número entero");
                else if (valor < min || valor > max)
                {
                    esCorrecto = false;
                    Console.WriteLine("\n\n\t** Error: el valor introducido no está dentro del rango");
                }
            } while (!esCorrecto);
            return valor;
        }
    }
}
