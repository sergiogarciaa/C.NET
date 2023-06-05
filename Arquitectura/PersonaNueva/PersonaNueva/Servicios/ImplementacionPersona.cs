using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PersonaNueva.Entidades;

namespace PersonaNueva.Servicios
{
    internal class ImplementacionPersona : InterfazPersona
    {
        public void mostrarPersona(List<Persona> listaPersona)
        {
            for (int i = 0; i < listaPersona.Count; i++)
            {
                Console.WriteLine(listaPersona[i].ToString());
            }
        }

        public void nuevaPersona(List<Persona> listaPersona)
        {
            string nombre;
            string apellidos;
            int anio;
            int mes;
            int dia;

            Console.WriteLine("Introduzca su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca su apellido");
            apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca su año");
            anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca su mes");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca su dia");
            dia = Convert.ToInt32(Console.ReadLine());
            

            Persona persona = new Persona(nombre, apellidos, anio, mes, dia);
            listaPersona.Add(persona);
        }
    }
}
