using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22p_Garcia_Sergio
{
    internal class P22p_Garcia_Sergio
    {
        const int FILASTABLA = 9, COLUMNASTABLA = 7;
        static double[,] tDoubles2D;
        static void Main(string[] args)
        {
            CargaTabla(FILASTABLA, COLUMNASTABLA);
            MostrarValores();



            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();
        }

        private static void MostrarValores()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n  ");
            // Cabecera de las columnas
            for (int i = 0; i < COLUMNASTABLA; i++)
            {
                Console.Write("      c{0}", i);
            }
            Console.WriteLine("\n");
            // Cabecera de las filas
            for (int i = 0; i < FILASTABLA; i++)
            {
                Console.WriteLine("f{0} > \n", i);
            }
            Console.ResetColor();

            for (int f = 0; f < FILASTABLA; f++)
            {
                for (int c = 0; c < COLUMNASTABLA; c++)
                {
                    ColocaValor(f, c);
                }
            }

        }

        private static void ColocaValor(int fTabla, int cTabla)
        {
            int filaPantalla, columnaPantalla; // Fila y columna de la pantalla

                            /* Es 8 porque arriba en la cabecera hay 8 saltos y así se cuadra */
            columnaPantalla = 7 + 8 * cTabla; // Columna de la pantalla en funcion de la columna de la pantalla

            filaPantalla = 4 + 2 * fTabla; // Fila de la pantalla en funcion de las filas tabla
            Console.SetCursorPosition(columnaPantalla, filaPantalla); // Coloca el cursor en la posición calculada y la escribe
            Console.Write(tDoubles2D[fTabla, cTabla]);
        }

        private static void CargaTabla(int filas, int columnas)
        {
            // Construimos la tabla global ya declarada
            tDoubles2D = new double[filas, columnas];
            Random azar = new Random();

            for (int f = 0; f < filas; f++) // Recorremos las filas
                for (int c = 0; c < columnas; c++) // Recorremos las columnas
                    tDoubles2D [f,c] = 0.1 * azar.Next(100, 1000);
              
        }

        static int CapturaEntero(string texto, int min, int max)
        {
            int num;
            bool esCorrecto;
            do
            {
                Console.Write(" {0} [{1}..{2}]: ", texto, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out num);
                if (!esCorrecto)
                    Console.WriteLine("\n\t ** ERROR de FORMATO **");
                else if (num < min || num > max)
                {
                    Console.WriteLine(" ** ERROR: VALOR FUERA DE RANGO **");
                    esCorrecto = false;
                }
            } while (!esCorrecto);

            return num;
        }
    }
}
