//Alumno: García Barrera, Sergio

using System;

namespace P14b_Garcia_Sergio
{
    internal class P14b_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            int opcion, numero1 = 1;

            do
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("\t\t\t╔═══════════════════════════════════════════════╗");
                Console.WriteLine("\t\t\t║                      MENU                     ║");
                Console.WriteLine("\t\t\t╠═══════════════════════════════════════════════╣");
                Console.WriteLine("\t\t\t║                                               ║");
                Console.WriteLine("\t\t\t║    1.- Enteros positivos menores de 200       ║");
                Console.WriteLine("\t\t\t║    2.- Los números pares menores de 200       ║");
                Console.WriteLine("\t\t\t║    3.- Los números impares entre 200 y 500    ║");
                Console.WriteLine("\t\t\t║                                               ║");
                Console.WriteLine("\t\t\t║                    0) Salir                   ║");
                Console.WriteLine("\t\t\t║                                               ║");
                Console.WriteLine("\t\t\t╚═══════════════════════════════════════════════╝");
                Console.Write("\t\tIntroduce una opción: ");

                //Registra la tecla introducida y continua

                opcion = Console.ReadKey().KeyChar - '0';
                Console.Clear();
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\n\n\t\tPulsa una tecla para salir");
                        Console.ReadLine();
                        break;
                    case 1:
                        Console.WriteLine("\t\t\tHa elegido la opción número 1: “Enteros positivos menores de 200”");
                        Console.WriteLine("\t\t\tExisten 3 formas de hacerse");
                        Console.WriteLine("\t\t\t1 -----> Bucle While");
                        Console.WriteLine("\t\t\t2 -----> Bucle For");
                        Console.WriteLine("\t\t\t3 -----> Bucle Do/While");
                        Console.Write("\t\t\tIntroduce una opción: ");
                        int opcion1 = Console.ReadKey().KeyChar - '0';
                        Console.Clear();
                        switch (opcion1)
                        {
                            // OPCION WHILE
                            case 1:
                                Console.WriteLine("\t\t\tHa seleccionado la opcion con while");

                                numero1 = 1;

                                while (numero1 < 200)
                                {
                                    Console.Write("\t{0}", numero1);
                                    numero1 = numero1 + 1;
                                }

                                break;
                            // OPCION FOR
                            case 2:
                                Console.WriteLine("\t\t\tHa seleccionado la opcion con for");

                                for (numero1 = 1; numero1 < 200; numero1++)
                                    Console.Write("\t{0}", numero1);

                                break;
                            // OPCION DO WHILE
                            case 3:
                                Console.WriteLine("\t\t\tHa seleccionado la opcion con do/while");

                                numero1 = 1;

                                do
                                {
                                    Console.Write("\t{0}", numero1);
                                    numero1++;
                                } while (numero1 < 200);

                                break;
                            default:
                                Console.WriteLine("\n\n\t\tNo ha eliegido una opción correcta, vuelva al menu principal");
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("\t\t\tHa elegido la opción no 2: “Los números pares menores de 200”");
                        Console.WriteLine("\t\t\tTiene 3 formas de hacerlo");
                        Console.WriteLine("\t\t\t1º -----> Bucle While");
                        Console.WriteLine("\t\t\t2º -----> Bucle For");
                        Console.WriteLine("\t\t\t3º -----> Bucle Do/While");
                        Console.Write("\t\t\tIntroduce una opción: ");
                        int opcion2 = Console.ReadKey().KeyChar - '0';
                        Console.Clear();
                        switch (opcion2)
                        {
                            case 1:
                                Console.WriteLine("\t\t\tHas seleccionado la opcion con while");

                                numero1 = 2;

                                while (numero1 <= 199)
                                {
                                    Console.Write("\t{0}", numero1);
                                    numero1 = numero1 + 2;
                                }
                                break;
                            case 2:
                                Console.WriteLine("\t\t\tHas seleccionado la opcion con for");


                                for (numero1 = 2; numero1 <= 199; numero1 += 2)
                                    Console.Write("\t{0}", numero1);

                                break;
                            case 3:
                                Console.WriteLine("\t\t\tHas seleccionado la opcion con do/while");

                                numero1 = 2;

                                do
                                {
                                    Console.Write("\t{0}", numero1);
                                    numero1 = numero1 + 2;
                                } while (numero1 <= 199);

                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\t\t\tHa elegido la opción no 3: “Los números impares entre 200 y 500”");
                        Console.WriteLine("\t\t\tHay 3 formas de hacerlo");
                        Console.WriteLine("\t\t\t1º -----> Bucle While");
                        Console.WriteLine("\t\t\t2º -----> Bucle For");
                        Console.WriteLine("\t\t\t3º -----> Bucle Do/While");
                        Console.Write("\t\t\tIntroduce una opción: ");
                        int opcion3 = Console.ReadKey().KeyChar - '0';
                        Console.Clear();
                        switch (opcion3)
                        {
                            case 1:
                                Console.WriteLine("\t\t\tHas seleccionado la opcion con while");

                                numero1 = 201;

                                while (numero1 >= 200 && numero1 <= 500)
                                {
                                    Console.Write("\t{0}", numero1);
                                    numero1 = numero1 + 2;
                                }

                                break;
                            case 2:
                                Console.WriteLine("\t\t\tHas seleccionado la opcion con for");

                                for (numero1 = 201; numero1 < 500; numero1 += 2)
                                    Console.Write("\t{0}", numero1);

                                break;
                            case 3:
                                Console.WriteLine("\t\t\tHas seleccionado la opcion con do/while");

                                numero1 = 201;

                                do
                                {
                                    Console.Write("\t{0}", numero1);
                                    numero1 = numero1 + 2;
                                } while (numero1 < 500);

                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("\n\n\t\tNo ha eliegido una opcion correcta, vuelva al menu principal");
                        break;
                }
                if (opcion != 0)
                {
                    Console.WriteLine("\n\n\t\tPulse una tecla para volver al menu");
                    Console.ReadKey();
                }
            } while (opcion != 0);
        }
    }
}
