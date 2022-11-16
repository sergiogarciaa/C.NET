using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21b_Garcia_Sergio
{
    internal class P21b_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            int numDias, diaDeLaSemana, diaDeLaSemanaFinal;
            string nombreDiaSemana = "", nombreDiaSemanaFinal = "";

            MuestraDiasSemana();

            diaDeLaSemana = CapturaOpcion(0,6);

            // Si el día es correcto continuamos
            if (diaDeLaSemana >= 0 && diaDeLaSemana <= 6)
            {
                Console.WriteLine("\n\tHoy es {0}", nombreDiaSemana);

                Console.Write("\tIntroduce cuántos días quieres avanzar: ");
                numDias = Convert.ToInt32(Console.ReadLine());

                if (numDias > 0)
                {
                    // Cálculo del día final
                    diaDeLaSemanaFinal = (numDias + diaDeLaSemana) % 7;

                    switch (diaDeLaSemanaFinal)
                    {
                        case 0:
                            nombreDiaSemanaFinal = "Domingo"; break;
                        case 1:
                            nombreDiaSemanaFinal = "Lunes"; break;
                        case 2:
                            nombreDiaSemanaFinal = "Martes"; break;
                        case 3:
                            nombreDiaSemanaFinal = "Miércoles"; break;
                        case 4:
                            nombreDiaSemanaFinal = "Jueves"; break;
                        case 5:
                            nombreDiaSemanaFinal = "Viernes"; break;
                        case 6:
                            nombreDiaSemanaFinal = "Sábado"; break;
                    }
                    Console.WriteLine("\n\tEstamos a {0} y dentro de {1} días será {2}", nombreDiaSemana, numDias, nombreDiaSemanaFinal);
                }
                else Console.WriteLine("\n\t¡¡Avanzar significa un número de días mayor de cero!!");
            }

            Console.Write("\n\n\t\tPulsa Intro para salir");
            Console.ReadLine();
        }

        static int CapturaOpcion(int min, int max)
        {
            int opcion;
            Console.Write("Pulsa una opción");
            opcion = Console.ReadKey().KeyChar - '0';
            // Comprobamos si es correcto
            while (opcion < min || opcion > max)
            {
                Console.WriteLine("Error no ha introducido una opcion correcta")
                Console.Write("Pulsa una opción");
                opcion = Console.ReadKey().KeyChar - '0';
            }
            return opcion;
        }
        static void MuestraDiasSemana()
        {
            // Muestro los días 
            Console.WriteLine("\n\t\t0) Domingo");
            Console.WriteLine("\n\t\t1) Lunes");
            Console.WriteLine("\n\t\t2) Martes");
            Console.WriteLine("\n\t\t3) Miércoles");
            Console.WriteLine("\n\t\t4) Jueves");
            Console.WriteLine("\n\t\t5) Viernes");
            Console.WriteLine("\n\t\t6) Sábado");
        }

        static string nombreDiaSemana (int idDiaSemana)
        {
            string nombreDiaSemana = string.Empty;

            switch (idDiaSemana)
            {
                case 0:
                    return "Domingo";
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                default:
                    Console.WriteLine("Valor incorrecto"); break;
            }
        }
    }
}
