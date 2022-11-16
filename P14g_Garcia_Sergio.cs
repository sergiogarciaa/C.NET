using System;

namespace P14g_Garcia_Sergio
{
    internal class P14g_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            const int COLUMNAS = 7;
            int cont = 0;

            for (int i = 32; i <= 255; i++)
            {
                if (i < 100)
                {
                    Console.Write(" ");
                }

                Console.Write("(" + i + ") " + (char)i + "\t");

                cont++;
                if (cont == COLUMNAS)       // Si he llegado al número de columnas...
                {
                    Console.WriteLine();    // ... Salto de línea...
                    cont = 0;
                }

                
                



            }
            Console.ReadLine();
        }
    }
}
