using ConsoleApp3.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.servicios
{
    internal class ImplementacionPersona : InterfazPersona
    {
        public void nuevaPersona(List<Persona> listaPersona)
        {
            string nombre;
            string apellidos;
            int anio;
            int mes;
            int dia;

            Console.WriteLine("Introduzca Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca Apellido: ");
            apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca año: ");
            anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca mes: ");
           mes = Convert.ToInt32(Console.ReadLine());
            if (mes > 1 && mes < 12)
            {
                Console.WriteLine("Introduzca día: ");
                dia = Convert.ToInt32(Console.ReadLine());
                if(dia > 1 && dia < 31)
                {
                    Persona persona = new Persona(nombre, apellidos, anio, mes, dia);
                    listaPersona.Add(persona);
                }
                else
                {
                    Console.WriteLine("Dia incorrecto.");
                }
            }
            else
            {
                Console.WriteLine("Mes incorrecto");
            }
        }

        public void mostrarPersona(List<Persona> listaPersona)
        {
            for (int i = 0; i < listaPersona.Count; i++)
            {
                Console.WriteLine(listaPersona[i].ToString()); 
            }
        }
 
    }
}
