using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasMartes13
{
    internal class Class1
    {
        // Pide Numeros y agrega a la lista
        public void PedirNumeros(List<int> listaEnteros)
        {
            bool seguir = true;
            int numero;

            do
            {
                Console.WriteLine("Introduce numeros enteros cuándo termines introduce [0] para salir: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 0)
                {
                    seguir = false;
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    listaEnteros.Add(numero);
                }
            } while (seguir);
        }

        // Ordena Lista de menor a mayor
        public void ComprobarLista(List<int> listaEnteros)
        {
            int aux;


            for (int i = 0; i < listaEnteros.Count; i++)
            {
                for(int j = i+1; j < listaEnteros.Count; j++)
                {
                    if(listaEnteros[i] > listaEnteros[j])
                    {
                        // Intercambia valores
                        aux = listaEnteros[i];
                        listaEnteros[i] = listaEnteros[j];
                        listaEnteros[j] = aux;

                    }
                }
            }
            for (int i = 0; i < listaEnteros.Count ; i++)
                Console.WriteLine(listaEnteros[i]);
        }


        public void pausa()
        {
            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();
        }
    }
}
