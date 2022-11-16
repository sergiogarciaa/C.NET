/*Repetir la práctica FechaEnTexto, (P13a) utilizando los métodos
• Captura: Que es como el del apartado b, y nos servirá para pedir los valores
del año, mes y día.
• FechaEnTexto recibe los tres enteros y devuelve la fecha como texto.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P20d_García_Sergio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anyo, mes, dia;

            anyo = Captura("Dime el año");
            mes = Captura("Dime el mes");

            if (mes < 1 || mes > 12) // <-- Mes incorrecto
                Console.WriteLine("\n\t\t** Error: Mes Fuera de rango **");
            else
            {
                dia = Captura("Dime el día");
                // Averiguo si el día es incorrecto -   
                if ((dia < 1 || dia > 31) || // <-- vale para todos los meses
                        (dia == 31 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || // <-- meses de 30 días
                        (dia > 28 && mes == 2)) // febrero
                    Console.WriteLine("\n\t\t** Error: día Fuera de rango **");
                else
                {
                    // Si llegamos aquí es que tanto el mes como el día es correcto
                    Console.WriteLine("\n\n\t\t La fecha es: {0} de {1} de {2} ", FechaEnTexto(anyo, mes, dia));
                }
            }


            Console.WriteLine("\n\n\t Pulsa INTRO para salir");
            Console.ReadLine();

        }

        static string FechaEnTexto (int a, int m, int d)
        {
            string fechaTxt = "";
            string nombreMes = "";
            switch (m)
            {
                case 1:
                    nombreMes = " Enero ";
                    break;
                case 2:
                    nombreMes = " Febrero ";
                    break;
                case 3:
                    nombreMes = " Marzo ";
                    break;
                case 4:
                    nombreMes = " Abril ";
                    break;
                case 5:
                    nombreMes = " Mayo ";
                    break;
                case 6:
                    nombreMes = " Junio ";
                    break;
                case 7:
                    nombreMes = " Julio ";
                    break;
                case 8:
                    nombreMes = " Agosto ";
                    break;
                case 9:
                    nombreMes = " Septiembre ";
                    break;
                case 10:
                    nombreMes = " Octubre ";
                    break;
                case 11:
                    nombreMes = " Noviembre ";
                    break;
                case 12:
                    nombreMes = " Diciembre ";
                    break;
            }

            fechaTxt = string.Format(d + " de " + nombreMes + " del " + a);
            return fechaTxt;
        }

        static int Captura (string txt)
        {
            int valor;
            Console.Write(txt);
            valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }

        //
    }
}
