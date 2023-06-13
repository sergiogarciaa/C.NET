     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasMartes13
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Lista de Enteros y ordenar
            // 1.- Instanciar.
            Class1 class1 = new Class1();
            List<int> ListaEnteros = new List<int>();
            // 2.- Llamada a métodos
            class1.PedirNumeros(ListaEnteros);            
            class1.ComprobarLista(ListaEnteros);
            class1.pausa();
        }

        
    }
}
