using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace p22f1_PresentaFecha1
{
    internal class P22f1_Garcia_Sergio
    {
        static String[] mes;
        static int[] dias;
        static void Main(string[] args)
        {
            int dia = 0;
            mes = new string[] { " ", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            dias = new int[31];

            // COMPOSICION DEL AÑO PARA EL METODO

            int anyo = CapturaEntero("Introduce un año [1750...2300]: ", 1750, 2300);
            int mesN = CapturaEntero("Introduce un mes [1...12]: ", 1, 12);

            // DETECTAR Nº DIAS EN EL MES INDICADO
            for (int i = 0; i < dias.Length; i++)
            {
                if (mesN == 2)
                {
                    dia = CapturaEntero("Introduce un día [1...28]: ", 1, 28);
                    break;
                }
                else if ((mesN == 4 || mesN == 6 || mesN == 9 || mesN == 11))
                {
                    dia = CapturaEntero("Introduce un día [1...30]: ", 1, 30);
                    break;
                }
                else
                    dia = CapturaEntero("Introduce un día [1...31]: ", 1, 31);
                break;
            }


            FechaString(anyo, mesN, dia);



            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();
        }

        private static void FechaString(int anio, int mesN, int dia)
        {
            // FORMAR TEXTO AÑO
            for (int i = 0; i < mes.Length; i++)
            {
                if (i == mesN)
                    Console.WriteLine("{0} de {1} de {2}", dia, mes[i], anio);

            }
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