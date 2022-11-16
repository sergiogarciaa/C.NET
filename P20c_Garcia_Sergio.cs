using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20c_Garcia_Sergio
{
    internal class Program
    {
        static int Captura()
        {
            int valor;
            Console.Write("\n\tdime tu edad: ");
            valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }

        static void Main(string[] args)
        {
            // Pedimos los datos
            int a = Captura();

            if (EsMayorMayorDeEdad(a))
                Console.WriteLine("Eres mayor de edad");
            else
                Console.WriteLine("Te faltan {0} años para ser mayor de edad");



            Console.Write("\n\n\n\t\tPulsa Intro para salir");
            Console.ReadLine();
        }

        static bool EsMayorMayorDeEdad(int edad)
        {
            bool esMayorMayorDeEdad;

            if (edad > 17)
                esMayorMayorDeEdad = true;
            else
                esMayorMayorDeEdad = false;

            return esMayorMayorDeEdad;

            // todo lo anterior se resume en una sola línea:
            // return (edad > 17);
        }

        
    }
}
