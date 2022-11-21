//Alumno: García Barrera, Sergio

/*Pide al usuario el tamaño de una tabla de enteros [5..20].
Se construye un vector de enteros vEnt con dicho tamaño.
Luego va pidiendo los valores de los elementos de la tabla [-30..50], hasta que
introduzcas un cero o se hayan cargado todos.
Por último mostrará, en una columna, todos los elementos de vEnt precedidos por
su índice.
Ejemplo: 0) 24.*/

using System;

namespace P22a_Garcia_Sergio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vEnt;
            int nc = 1;
            int a = CapturaEntero("Introduzca el tamaño de una tabla de enteros.", 5, 20);
            vEnt = new int[a];
            for(int i = 0; i < vEnt.Length; i++)
            {
                if (i % nc == 0)
                {
                    Console.WriteLine();
                }
                int num = CapturaEntero("Valores de los elementos de la tabla, si introduces 0 se terminará.", -30, 50);
                if(num == 0){break;}
                vEnt[i] = num;
                
            }
            for (int i = 0; i < vEnt.Length; i++)
            {
                Console.WriteLine(i + 1 + ") " + vEnt[i]);
            }

            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadKey();
        }
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
        }
    }
}
