// Alumno: Garcia Barrera, Sergio

/*Método Menú:
Resolver la práctica Menu-While (14e) utilizando el método Menu:
• Recibe: Nada.
• Hace: Presenta el cuadro de las opciones del menú y espera que el usuario
pulse una opción correcta. Mientras no lo haga, seguirá esperando.
• Devuelve: El valor numérico que representa la opción pulsada.

Cada una de las cuatro opciones posibles se realizará en un método en lugar del
Main. Las llamadas a dichos métodos serían las siguientes:
MultiplosMenoresDe(num, 300);
PrimerosMúltiplos(num, 100);
MúltiplosEntre(num, 500, 700);
NMúltiplosDesde(num, 80, 700);*/

using System;


namespace P21E_GarciaBarrera_Sergio
{
    internal class P21e_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            int num = 0, multiplo;
            int opcion;
            

            do {
                opcion = Menu();
                Console.Clear();
                if (opcion != 0)
                {
                    num = CapturaEntero("Introduzca un número de dos cifras", 10,99);
                }
                       

                switch (opcion)
                {
                    case 1:
                        MultiplosMenoresDe(num, 300);
                        break;

                    case 2:
                        PrimerosMúltiplos(num, 100);
                        break;

                    case 3:
                        MúltiplosEntre(num, 500, 700);
                        break;

                    case 4:
                        NMúltiplosDesde(num, 80, 700);
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\n\nPulse una tecla para Volver al menú");
                    Console.ReadKey();
                }

            }while(opcion != 0);

            Console.Write("\n\n\tPulsa una tecla para salir");
            Console.ReadKey();
        }

        private static void NMúltiplosDesde(int num, int min, int max)
        {
            Console.WriteLine("\n\t----- {1} primeros múltiplos de {0} a partir de {2} -----", num, min, max);
            Console.WriteLine("\t-------------------------------------------------------\n");

            //---- Averiguamos el primer múltiplo:
            // Múltiplo igual o inmediatamente anterior a 700
            int multiplo = (max / num) * num;
            //Como el 700 está incuido, sólo incremento múltiplo si ha salido menor
            if (multiplo < max)
                multiplo += num;

            // A partir de ese número incluido, escribo 80 más 
            for (int i = 0; i < min; i++)
            {
                Console.Write("\t" + multiplo);
                multiplo += num;
            }
        }

        static int Menu()
        {
            int opcion;

            Console.Clear();
            Console.WriteLine("\n\n\t\t╔════════════════════════════════════╗");
            Console.WriteLine("\t\t║           Menú Múltiplos           ║");
            Console.WriteLine("\t\t╠════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   1) Múltiplos menores 300         ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   2) Cien Primeros Múltiplos       ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   3) Múltiplos Entre 500 y 700     ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   4) Ochenta Múltiplos Desde 700   ║");
            Console.WriteLine("\t\t║____________________________________║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║           0) Salir                 ║");
            Console.WriteLine("\t\t╚════════════════════════════════════╝");

            Console.Write("\t\tIntroduce una opción: ");
            opcion = Console.ReadKey().KeyChar - '0';
            // Comprobamos que se ha pulsado una opción correcta
            while (opcion < 0 || opcion > 4)
            {
                Console.WriteLine("\n\t\t\t*ERROR*");
                Console.Write("\t\tIntroduce una opción: ");
                opcion = Console.ReadKey().KeyChar - '0';
            }

            return opcion;

        }

        private static void MúltiplosEntre(int num, int min, int max)
        {
            Console.WriteLine("\n\t----- Múltiplos de {0} entre {1} y {2} -----", num, min, max);
            Console.WriteLine("\t-------------------------------------------\n");
            //---- Averiguamos el primer múltiplo:
            // Múltiplo igual o inmediatamente anterior a 500
            int multiplo = (500 / num) * num;

            if (multiplo < 500)
                multiplo += num;// múltiplo de num inmediatamente superior a 500

            //---- Busco y muestro todos los demás múltiplos (menores o iguales a 700)
            while (multiplo <= 700)
            {
                Console.Write("\t{0}", multiplo);
                multiplo += num;
            }
        }

        private static void PrimerosMúltiplos(int num, int cantidad)
        {
            Console.WriteLine("\n\t----- {1} primeros múltiplos de {0} -----", num, cantidad);
            Console.WriteLine("\t----------------------------------------\n");

            for (int i = 1; i <= cantidad; i++)
                Console.Write("\t{0}", i * num);
        }

        private static void MultiplosMenoresDe(int num, int tope)
        {
            Console.WriteLine("\n\t----- Múltiplos de {0} menores de {1} -----", num, tope);
            Console.WriteLine("\t------------------------------------------\n");
            int multiplo = num; // <-- Primer múltiplo
            while (multiplo < tope)
            {
                Console.Write("\t" + multiplo);
                // siguiente múltiplo
                multiplo += num;
            }
        }
        static int CapturaEntero(string txt, int min, int max)
        {
            int valor;
            bool esCorrecto;

            do
            {
                Console.Write("{0} [{1}..{2}]: ", txt, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
        //        comprobamos si lo que he escrito es un entero
                if (!esCorrecto)
                    Console.WriteLine("\n** Error: Valor introducido no es un número entero **");
         //       comprobamos si lo que he escrito está dentro del rango
                else if (valor < min || valor > max)
                    Console.WriteLine("\n** Error: El número no está en el rango pedido **");

            } while (!esCorrecto || valor < min || valor > max);

            return valor;
        }

    }
}
