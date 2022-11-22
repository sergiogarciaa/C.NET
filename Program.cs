using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22d1_VectorNonesGlobal
{
    internal class Program
    {
        static int[] vNones;
        static void Main(string[] args)
        {
            int numE;
            numE = CapturaEntero("\n\n\tCuantos impares quiere cargar en el programa?", 5, 100);
            vNones = new int[numE]; 
            CargaTablaNones(numE);
            MuestraTabla();
    


            Console.ReadLine();
        }

        static void MuestraTabla()
        {
            int nc;
            Console.WriteLine("En cuántas columnas los quieres mostrar [1..8]");
            nc = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < vNones.Length; i++)
            {

                // cuando el contador sea múltiplo del nº de columnas...
                // Salto de línea
                if (i % nc == 0)
                    Console.WriteLine();

                Console.Write("{0}) {1}\t", i, vNones[i]);
            }
        }

        static void CargaTablaNones(int num)
        {
            int x;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Introduce un número impar para añadirlo al vector");
                x = Convert.ToInt32(Console.ReadLine());
                while(x % 2 == 0)
                {
                    Console.WriteLine("Este número no es par, introduce un impar");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                if (x % 2 != 0) // si el min es par, el primer impar será el siguiente.
                    vNones[i] = x;
            }
        }
        static int CapturaEntero(string texto, int min, int max)
        {
            bool esCorrecto;
            int valor;
            do
            {
                Console.Write("{0} [{1}..{2}]:", texto, min, max);
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
