using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14c_Garcia_Sergio
{
    internal class P14c_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            int juego = 1;
            int contador = 0;
            Random maquina = new Random();

            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.WriteLine("\t\t\t╔═══════════════════════════════════════════════╗");
                Console.WriteLine("\t\t\t║                      MENU                     ║");
                Console.WriteLine("\t\t\t╠═══════════════════════════════════════════════╣");
                Console.WriteLine("\t\t\t║                                               ║");
                Console.WriteLine("\t\t\t║        1.- Acierta número básico              ║");
                Console.WriteLine("\t\t\t║        2.- Acierta número de tres             ║");
                Console.WriteLine("\t\t\t║                                               ║");
                Console.WriteLine("\t\t\t║                    0) Salir                   ║");
                Console.WriteLine("\t\t\t║                                               ║");
                Console.WriteLine("\t\t\t╚═══════════════════════════════════════════════╝");
                Console.Write("\t\tIntroduce una opción: ");

                juego = Console.ReadKey().KeyChar - '0';
                Console.Clear();
                switch (juego)
                {
                    case 0:
                        Console.WriteLine("\t\t\tPulse una tecla para salir");
                        Console.ReadLine();
                        break;
                    case 1:
                        // JUEGO Nº1

                        Console.WriteLine("\t\t\tHa elegido el juego número 1: “Acierta número básico”");
                        int jugador1 = 1;

                        //Jugador 1 Introduce número

                        while(jugador1 < 10 || jugador1 > 20)
                        {
                            Console.WriteLine("\n\n\t\t\t Introduzca un número entre 10 y 20");
                            jugador1 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Clear();

                        int jugador2 = 1;

                        // Jugador 2 Adivina número
                        while(jugador1 != jugador2)
                        {
                            Console.WriteLine("\n\n\t\t\t Introduzca un número entre 10 y 20, intente adivinar el número", jugador1);
                            jugador2 = Convert.ToInt32(Console.ReadLine());
                            //Detecta si falló o acertó y si falló incrementa el contador
                            if (jugador2 != jugador1)
                            {
                                Console.WriteLine("Has fallado, intentalo de nuevo", contador);
                                contador++;
                            }
                            else if (jugador2 == jugador1)
                            {
                                Console.Clear();
                                Console.WriteLine("¡Acertaste en {0} intentos!, el número correcto era {1}", contador, jugador1);
                            }
                        }
                    break;
                    case 2:
                        //Juego Nº2
                        Console.WriteLine("\t\t\tHa elegido el juego número 2: “Acierta número de tres”");
                        int numaleatorio = maquina.Next(10, 20+1);
                        int jugadorsolo = 1;
                        while (jugadorsolo != numaleatorio)
                        {
                            Console.WriteLine("\n\n\t\t Introduzca un número entre 10 y 20, intente adivinar el número", numaleatorio);
                            jugadorsolo = Convert.ToInt32(Console.ReadLine());
                            //Detecta si falló o acertó y si falló incrementa el contador
                            if (jugadorsolo != numaleatorio)
                            {
                                Console.WriteLine("Has fallado, intentalo de nuevo", contador);
                                contador++;
                                if (contador == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Has fallado {0} veces, el número correcto era {1}, lo siento.", contador, numaleatorio);
                                    break;
                                }
                            }
                            else if (jugadorsolo == numaleatorio)
                            {
                                Console.Clear();
                                Console.WriteLine("¡Acertaste en {0} intentos!, el número correcto era {1}", contador, numaleatorio);
                            }
                        }
                    break;
                    default:
                        Console.WriteLine("\n\n\t\tNo ha eliegido una opcion correcta, vuelva al menu principal");
                        break;
                }


                //Tecla equivocada y le vuelve a saltar el menu
                if (juego != 0)
                {
                    Console.WriteLine("\n\n\t\tPulse una tecla para volver al menu");
                    Console.ReadKey();
                }
            } while (juego != 0);
        }
    }
}
