using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar
{
    internal class class1
    {
        int[] array1 = new int[101];
        Random rnd = new Random();

        public void GeneraNumeros()
        {
            for (int i = 0; i < 100; i++)
            {
                array1[i] = rnd.Next(1, 101);
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if(i == 0)
                {
                    i += 1;
                }
                Console.WriteLine(i + ") " + array1[i]);
            }
        }

        public void Ordenar()
        {

            Boolean ordenado = true;

            do {
                ordenado = true;
                for (int i = 0; i < array1.Length; i++)
                {
                    // J siempre va a estar por delante
                    for (int j = i+1; j < array1.Length; j++)
                    {
                        // Se compara si i es mayor que j para cambiarlo
                        if (array1[i] > array1[j])
                        {
                            cambiar(i, j);
                            ordenado = false;
                        }
                    }
                }
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine(array1[i]); 
                }
            } while (!ordenado);

            /* Metodo rápido
            Array.Sort(array1);
            Console.WriteLine("Array After Sorting:\n");
            foreach (int menor in array1)
            {
                Console.WriteLine(menor + " ");
            }*/
        }

        private void cambiar(int i, int j)
        {
            // Cambio de posiciones mediante auxiliar
            int aux = array1[i];
            array1[i] = array1[j];
            array1[j] = aux;
        }

        public void pausa()
        {
            Console.WriteLine("Pulsa un botón para salir");
            Console.ReadKey();
        }
    }
}
