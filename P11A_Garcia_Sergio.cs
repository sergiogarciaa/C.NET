// Alumno: García Sergio

/* Area y perímetro de un círculo

 * Se introduce el radio de un círculo e imprimirá la longitud de su círculo de su circunferencia y su área
 * longitud = 2 * pi * r        área = pi * r2.

 */


using System;
using System.Text.RegularExpressions;


namespace P11A_Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radio;
            double perimetro, area;
            String captura;


            Console.WriteLine("Introduce el radio: ");
            captura = Console.ReadLine();
            radio = Convert.ToInt32(captura);
            perimetro = 2 * 3.14 * radio;
            area = 3.14 * radio;
            Console.WriteLine("\nEl área de un círculo de radio = " + radio + " es " + area);
            Console.WriteLine("\n El perimetro del circulo anterior es " + perimetro);
            Console.Write("\n\n Pulsa Intro para salir");
            Console.ReadLine();
           // Console.WriteLine("El radio es {0}, la longitud es {1}", radio, longitud(longitud = 2 * PI * radio));


        }
    }
}
