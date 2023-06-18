using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.servicios
{
    internal class ImplementacionMenu : InterfazMenu
    {
        public void MostrarMenu()
        {
            Console.WriteLine("1. Nueva Persona");
            Console.WriteLine("2. Mostrar Personas");
            Console.WriteLine("3. Salir");
        }
    }
}
