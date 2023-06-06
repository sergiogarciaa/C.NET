using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 mt = new class1();
            
            mt.GeneraNumeros();
            mt.pausa();
            mt.Ordenar();
            mt.pausa();
        }
    }
}
