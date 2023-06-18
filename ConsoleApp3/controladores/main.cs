using ConsoleApp3.entidades;
using ConsoleApp3.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.controladores
{
    internal class main
    {
        static void Main(string[] args)
        {
            InterfazMenu menu = new ImplementacionMenu();
            InterfazPersona persona = new ImplementacionPersona();
            List<Persona> listaPersona = new List<Persona>();
            bool seguir = true;
            int opcion;

            do
            {
                menu.MostrarMenu();
                Console.WriteLine("Introduzca la opción deseada: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        persona.nuevaPersona(listaPersona);
                        break;
                    case 2:
                        persona.mostrarPersona(listaPersona);
                        break; 
                    case 3:
                        seguir = false;
                        break;
                    default: 
                        Console.WriteLine("Opción incorrecta.");
                            break;
                }



            } while (seguir);
        }
        
    }
}
