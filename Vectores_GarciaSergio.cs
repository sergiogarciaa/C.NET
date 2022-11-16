using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22_Garcia_Sergio
{
    internal class Vectores_GarciaSergio
    {
        static void Main(string[] args)
        {
            /*0) Declarar un vector de enteros
                • Fijar el tamaño que quieras [10..100] en la declaración;
                • Cargarlo con valores aleatorios entre 1 y 1000.
                • Presentar los valores en una columna.*/

            int nc = 1;
            int[] array = new int [15];
            Random num = new Random();

            for(int i = 0; i<array.Length; i++)
            {
                // cuando el contador sea múltiplo del nº de columnas...
             // Salto de línea
                if (i % nc == 0)
                {
                    Console.WriteLine();
                }
                array[i] = num.Next(1, 1001);
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
            Console.Clear();

            /*1) Declarar un vector de enteros
                • Fijar el tamaño que quieras [10..100]. Para esto pídele al usuario que te
                indique el tamaño (con CapturaEntero)
                • Cargarlo con valores aleatorios entre 1 y 1000.
                • Presentar los valores en una columna precedidos de su posición en el vector.*/

            int a = 0;
            int[] array2;

            a = CapturaEntero("\n\tCantidad de múltiplos a presentar?", 10, 100);
            array2 = new int[a];

            for (int i = 0; i < array2.Length; i++)
            {
                // cuando el contador sea múltiplo del nº de columnas...
                // Salto de línea
                if (i % nc == 0)
                {
                    Console.WriteLine();
                }
                array2[i] = num.Next(1, 1001);
                Console.WriteLine(array2[i]);
            }

            Console.ReadLine();
            Console.Clear();

            /*Declarar un vector de caracteres
            • Fijar el tamaño que quieras [10..100] (si quieres, para esto pídele al usuario
            que te indique el tamaño)
            • Cargarlo con valores aleatorios entre el espacio (32) y el '~' (126).
            • Presentar en una columna precedidos de su posición en la tabla.
            <id de la tabla>) <carácter> --> <código del carácter>.
            Ejemplo: 17) $ --> 36*/

            int b = 0;
            int[] array3;

            b = CapturaEntero("\n\tCantidad de múltiplos a presentar?", 10, 100);
            array3 = new int[b];

            for (int i = 0; i < array3.Length; i++)
            {
                // cuando el contador sea múltiplo del nº de columnas...
                // Salto de línea
                if (i % nc == 0)
                {
                    Console.WriteLine();
                }

                array2[i] = num.Next(32, 127);
                Console.WriteLine( i+1 + ")  "+ array2[i] + " --> " + (char)array2[i]);
            }
            Console.ReadLine();
        } // FIN MAIN


        // METODO CAPTURA ENTEROS
        static int CapturaEntero(string txt, int min, int max)
        {
            int valor;
            bool esCorrecto;

            Console.Write("{0} [{1}..{2}]: ", txt, min, max);
            esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
            while (!esCorrecto || valor < min || valor > max)
            {
                // comprobamos si lo que he escrito es un entero
                if (!esCorrecto)
                    Console.WriteLine("\n** Error: Valor introducido no es un número entero **");
                // comprobamos si lo que he escrito está dentro del rango
                else
                    Console.WriteLine("\n** Error: El número no está en el rango pedido **");

                Console.Write("{0} [{1}..{2}]: ", txt, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        } //fin CapturaEnteros

    }
}
