using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22f2_PresentaFechasOK
{
    internal class Program
    {
        static String[] mes;
        static int[] dias;
        static void Main(string[] args)
        {
            bool continuar;
            do
            {
                Console.Clear();
                int dia = 0;
                mes = new string[] { " ", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
                dias = new int[31];

                // COMPOSICION DEL AÑO PARA EL METODO

                int anyo = CapturaEntero("Introduce un año [1300...2300]: ", 1300, 2300);
                // Mirar si es bisiesto y guardarlo en variable
                bool sino = EsBisiesto(anyo);
                int mesN = CapturaEntero("Introduce un mes [1...12]: ", 1, 12);

                // DETECTAR Nº DIAS EN EL MES INDICADO
                for (int i = 0; i < dias.Length; i++)
                {
                    if (mesN == 2)
                    {
                        //Modifica segun el bool sino (Bisiesto o no)
                        if (sino == true)
                        {
                            dia = CapturaEntero("Introduce un día [1...29]: ", 1, 29);
                            break;
                        }
                        else
                        {
                            dia = CapturaEntero("Introduce un día [1...28]: ", 1, 28);
                            break;
                        }

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

                continuar = PreguntaSiNo("Desea repetir el programa?");

            } while (continuar);


            Console.Clear();
            Console.Write("Buen viaje!!");
            Console.ReadKey();
        }

        static bool PreguntaSiNo(string txt)
        {
            char pulsa;

            do
            {
                Console.Write("\n\n\t{0} (s= Sí, n= No): ", txt);
                pulsa = (Console.ReadKey()).KeyChar;

                if (pulsa == 's' || pulsa == 'S')
                {
                    return true;
                }
                if (pulsa == 'n' || pulsa == 'N')
                {
                    return false;
                }


                Console.Clear();
                Console.WriteLine("ERROR, PULSA: S o N");
            } while (true);
        }

        static bool EsBisiesto(int anio)
        {

            if (anio % 4 == 0 && anio % 100 != 0 || anio% 400 == 0)
            {
                Console.WriteLine("{0} es un año bisiesto.\n", anio);
                return true;
            }
            else
            {
                Console.WriteLine("{0} no es un año bisiesto. \n", anio);   
                return false;
            }
        }

        static void FechaString(int anio, int mesN, int dia)
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
