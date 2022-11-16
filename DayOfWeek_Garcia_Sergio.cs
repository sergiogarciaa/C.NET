using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diadelasemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, sumaDia, nuevoDia;

            Console.Write("\n\tIntroduce un dia de la semana del 0 (domingo) al 6 (sabado): ");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 0: Console.Write("\n\tHoy es Domingo");
                    break;
                case 1: Console.Write("\n\tHoy es Lunes");
                    break;
                case 2: Console.Write("\n\tHoy es Martes");
                    break;
                case 3: Console.Write("\n\tHoy es Miercoles");
                    break;
                case 4: Console.Write("\n\tHoy es Jueves");
                    break;
                case 5: Console.Write("\n\tHoy es Viernes");
                    break;
                case 6: Console.Write("\n\tHoy es Sabado");
                    break;
                default: Console.Write("\n\tDía fuera de rango");
                    break;
            }

            Console.Write("\n\tIntroduce cuantos dias quiere avanzar: ");
            sumaDia = Convert.ToInt32(Console.ReadLine());

            nuevoDia = (dia + sumaDia) % 7;

            if (nuevoDia == 0)
                Console.Write("\n\tDentro de {0} dias sera domingo", sumaDia);
            else if (nuevoDia == 1)
                Console.Write("\n\tDentro de {0} dias sera lunes", sumaDia);
            else if (nuevoDia == 2)
                Console.Write("\n\tDentro de {0} dias sera martes", sumaDia);
            else if (nuevoDia == 3)
                Console.Write("\n\tDentro de {0} dias sera miercoles", sumaDia);
            else if (nuevoDia == 4)
                Console.Write("\n\tDentro de {0} dias sera jueves", sumaDia);
            else if (nuevoDia == 5)
                Console.Write("\n\tDentro de {0} dias sera viernes", sumaDia);
            else if (nuevoDia == 6)
                Console.Write("\n\tDentro de {0} dias sera sabado", sumaDia);

            Console.Write("\n\tPulsa intro para salir...");
            Console.ReadLine();
        }
    }
}
