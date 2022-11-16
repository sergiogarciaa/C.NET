//Alumno: García Barrera, Sergio

using System;

namespace P14i_Garcia_Sergio
{
    internal class P14i_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            int a, b;
            bool positivo;
            char opcion = 'S';
            int resultado;
            do
            {
                //Permitir A
                do
                {
                    resultado = 0;
                    Console.Clear();
                    Console.WriteLine("Introduce el valor A: ");
                    positivo = Int32.TryParse(Console.ReadLine(), out a);

                    if (!positivo)
                    {
                        Console.WriteLine("Error, inválido");
                    }
                    else if (a < 0)
                    {
                        Console.WriteLine("Error, no se permiten números negativos");
                    }
                } while (!positivo || a < 0);

                // Permitir B
                do
                {
                    Console.WriteLine("Introduce el valor B: ");
                    positivo = Int32.TryParse(Console.ReadLine(), out b);

                    if (!positivo)
                    {
                        Console.WriteLine("Error, inválido");
                    }
                    else if (b < 0)
                    {
                        Console.WriteLine("Error, no se permiten números negativos");
                    }
                } while (!positivo || b < 0);


                for (int i = 0; i < b; i++)
                {
                    resultado += a;
                }

                Console.WriteLine("El producto {0} x {1} = {2}", a, b, resultado);

                Console.WriteLine("Pulsa S si quieres hacer otra multiplicación, sino pulsa otra cosa");
                opcion = Console.ReadKey().KeyChar;
            } while (opcion == 's' || opcion == 'S');

        }
    }
}
