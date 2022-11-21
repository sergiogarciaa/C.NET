using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22b_Garcia_Sergio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int nc = 1;
            int numadiv;
            int[] vEnt;
            Random num = new Random();

            b = CapturaEntero("\n\tCantidad de múltiplos a presentar?", 5, 100);
            vEnt = new int[b];

            for (int i = 0; i < vEnt.Length; i++)
            {
                vEnt[i] = num.Next(10, 100);
            }
            for (int i = 0; i < vEnt.Length; i++)
            {
                if (i % nc == 0){Console.WriteLine();}
                Console.Write(i + ") " + vEnt[i]);
            }

            do
            {
                bool numencontrado = false;
                numadiv = CapturaEntero("Qué número desea buscar?", 0, 99);
                
                for (int i = 0; i < vEnt.Length; i++)
                {
                    if (numadiv == vEnt[i])
                    {
                        if (!numencontrado)
                        {
                            Console.WriteLine("El número {0} se encuentra en la/s posición/es", numadiv);
                        }
                        Console.WriteLine("\t" + i);
                        numencontrado = true;
                    }
                }
                if (!numencontrado)
                {
                    Console.WriteLine("El número {0} no existe en la tabla", numadiv);
                }
            } while (numadiv != 0);
        }
        // METODO CAPTURA ENTEROS
        static int CapturaEntero(string txt, int min, int max)
        {
            int valor;
            bool esCorrecto;

            Console.WriteLine("{0} [{1}..{2}]: ", txt, min, max);
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
