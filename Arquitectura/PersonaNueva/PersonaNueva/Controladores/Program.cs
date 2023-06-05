using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonaNueva.Entidades;
using PersonaNueva.Servicios;

namespace PersonaNueva
{
    internal class Program
    {
        static void Main(string[] args)
        {;
            InterfazMenu menu = new ImplementacionMenu();
            InterfazPersona cPersona = new ImplementacionPersona();
            List<Persona> listaPersona = new List<Persona>();
            int opcion;
            Boolean cerrarMenu = false;



            while (!cerrarMenu)
            {
                //Mostramos el menú
                menu.MostrarMenu();
                Console.WriteLine("Introduza la opción deseada: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("[INFO] - Has seleccionado la opcion " + opcion);

                switch (opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        cPersona.nuevaPersona(listaPersona);
                        break;
                    case 2:
                        cPersona.mostrarPersona(listaPersona);
                        break;

                }
            }
        }
    }
}
