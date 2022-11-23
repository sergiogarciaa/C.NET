using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22f1_Presenta_Fecha
{
    internal class P22f1_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            CapturaFechaString();

            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();  
        }

        private static void CapturaFechaString()
        {
            int anyo; int mes; int dia;
            String nombreMes = "";

            anyo = CapturaEntero("Introduce un año [1750...2300]: ", 1750, 2300);
            mes = CapturaEntero("Introduce un mes [1...12]: ", 1, 12);  
           
                if (mes == 2)
                {
                    dia = CapturaEntero("Introduce un día [1...28]: ", 1, 28);
                }
                else if ((mes == 4 || mes == 6 || mes == 9 || mes == 11))
                {
                    dia = CapturaEntero("Introduce un día [1...30]: ", 1, 30);
                }
                else
                    dia = CapturaEntero("Introduce un día [1...31]: ", 1, 31);

            switch (mes)
            {
                case 1: nombreMes = "Enero";
                    break;
                case 2: nombreMes = "Febrero";
                    break;
                case 3: nombreMes = "Marzo";
                    break;
                case 4: nombreMes = "Abril";
                    break;
                case 5: nombreMes = "Mayo";
                    break;
                case 6: nombreMes = "Junio";
                    break;
                case 7: nombreMes = "Julio";
                    break;
                case 8: nombreMes = "Agosto";
                    break;
                case 9: nombreMes = "Septiembre";
                    break;
                case 10: nombreMes = "Octubre";
                    break;
                case 11: nombreMes = "Noviembre";
                    break;
                case 12: nombreMes = "Diciembre";
                    break;
            }
            Console.WriteLine("{0} de {1} de {2}", dia, nombreMes, anyo);
        }
        static int CapturaEntero(string texto, int min, int max)
        {
            bool esCorrecto;
            int valor;
            do
            {
                Console.Write("{0}: ", texto, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto)
                    Console.WriteLine("\n\n\t** Error: el valor introducido no es un número entero");
                else if (valor < min || valor > max)
                {
                    esCorrecto = false;
                    Console.WriteLine("\n\n\t** Error: el valor introducido no está dentro del rango");
                }
            } while (!esCorrecto);
            return valor;
        }
    }
}
