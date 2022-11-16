using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13E_Garcia_Sergio
{
    internal class P13E_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            //Variables
            int lectura;
            int albañil, gruista, electricista, fontanero, oficinista;

            Console.WriteLine("\t\t\t╔════════════════════════════════════╗");
            Console.WriteLine("\t\t\t║ id   profesión   ║ euros/h  hs/dia ║");
            Console.WriteLine("\t\t\t╠════════════════════════════════════╣");
            Console.WriteLine("\t\t\t║                  ║                 ║");
            Console.WriteLine("\t\t\t║ 1    Albañil     ║   12       8    ║");
            Console.WriteLine("\t\t\t║ 2    Gruista     ║   15       7    ║");
            Console.WriteLine("\t\t\t║ 3    Electricista║   16       5    ║");
            Console.WriteLine("\t\t\t║ 4    Fontanero   ║   14       5    ║");
            Console.WriteLine("\t\t\t║ 5    Oficinista  ║   10       2    ║");
            Console.WriteLine("\t\t\t║ 0) Salir         ║                 ║");
            Console.WriteLine("\t\t\t║                  ║                 ║");
            Console.WriteLine("\t\t\t╚════════════════════════════════════╝");
            Console.Write("\t\tIntroduce una opción: ");
            lectura = Console.ReadKey().KeyChar - '0';

            switch (lectura)
            {
                case 0:
                    Console.WriteLine("\n\nGracias por acudir a nosotros");
                    break;
                case 1:
                    Console.Write("\n\nHa solicitado el trabajo de Albañil");
                    break;
                case 2:
                    Console.Write("\n\nHa solicitado el trabajo de Gruista");
                    break;
                case 3:
                    Console.Write("\n\nHa solicitado el trabajo de Electricista");
                    break;
                case 4:
                    Console.Write("\n\nHa solicitado el trabajo de Fontanero");
                    break;
                case 5:
                    Console.Write("\n\nHa solicitado el trabajo de Oficinista");
                    break;
                default:
                    Console.Write("\n\nNo ha escogido un ID valido");
                    break;
            }

            if (lectura == 1)
            {
                Console.WriteLine(" ¿Cuántos días necesitará al Albañil? ");
                albañil = Convert.ToInt32(Console.ReadLine());
                int coste = albañil * 8 * 12;
                Console.WriteLine("Saldría un total de: " + coste + " euros");
            }
            else if (lectura == 2)
            {
                Console.WriteLine(" ¿Cuántos días necesitará al Gruista? ");
                gruista = Convert.ToInt32(Console.ReadLine());
                int coste = gruista * 7 * 15;
                Console.WriteLine("Saldría un total de: " + coste + " euros");
            }
            else if (lectura == 3)
            {
                Console.WriteLine(" ¿Cuántos días necesitará al Electricista? ");
                electricista = Convert.ToInt32(Console.ReadLine());
                int coste = electricista * 5 * 16;
                Console.WriteLine("Saldría un total de: " + coste + " euros");
            }
            else if (lectura == 4)
            {
                Console.WriteLine(" ¿Cuántos días necesitará al Fontanero? ");
                fontanero = Convert.ToInt32(Console.ReadLine());
                int coste = fontanero * 5 * 14;
                Console.WriteLine("Saldría un total de: " + coste + " euros");
            }
            else if (lectura == 5)
            {
                Console.WriteLine(" ¿Cuántos días necesitará al Oficinista? ");
                oficinista = Convert.ToInt32(Console.ReadLine());
                int coste = oficinista * 2 * 10;
                Console.WriteLine("Saldría un total de: " + coste + " euros");
            }

            Console.WriteLine("\n\nPulsa una tecla para salir");
            Console.ReadKey();

        }
    }
}
