using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaNueva.Servicios
{
    internal class ImplementacionMenu : InterfazMenu {
        public void MostrarMenu()
        {
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Crear Persona");
            Console.WriteLine("2. Mostrar Personas");
        }
    }
}
