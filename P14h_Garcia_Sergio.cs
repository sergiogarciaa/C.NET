// Alumno: García Barrera, Sergio

using System;

namespace P14h_Garcia_Sergio
{
    internal class P14h_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            int cant;
            int num;
            int minimo;
            int nc;
            int contador = 0;
            bool ok;

            // COMPROBACIONES DE QUE SON CORRECTO LO QUE SE INTRODUCE
                do
                {
                    Console.WriteLine("Introduce una cantidad de múltiplos a presentar.");
                    ok = Int32.TryParse(Console.ReadLine(), out cant);
                    if (!ok)
                    {
                        Console.WriteLine("Error, inválido");
                    }
                }while (!ok);

                do
                {
                    Console.WriteLine("Número del que vamos a presentar sus múltiplos");
                    ok = Int32.TryParse(Console.ReadLine(), out num);
                    if (!ok)
                    {
                        Console.WriteLine("Error, inválido");
                    }
                } while (!ok);

                do
                {
                    Console.WriteLine("Valor a partir del cual hallaremos los múltiplos.");
                    ok = Int32.TryParse(Console.ReadLine(), out minimo);
                    if (!ok)
                    {
                        Console.WriteLine("Error, inválido");
                    }
                } while (!ok);

                do
                {
                    Console.WriteLine("Número de columnas de la presentación");
                    ok = Int32.TryParse(Console.ReadLine(), out nc);
                    if (!ok)
                    {
                        Console.WriteLine("Error, inválido");
                    }
                } while (!ok);

            Console.WriteLine("\n\t----- ,{0} múltiplos de {1} a partir de {2} -----",cant, num, minimo);
            Console.WriteLine("\t-------------------------------------------------------\n");

            int multiplo = (minimo / num) * num;

            if (multiplo < minimo)
            {
                multiplo += num;
            }

            for (int i = 0; i < cant; i++)
            {
                //--- Controlar las columnas
                if (contador++ % nc == 0)
                    Console.WriteLine();

                Console.Write("\t" + multiplo);
                multiplo += num;
            }
            Console.ReadLine();
        }
    }
}
