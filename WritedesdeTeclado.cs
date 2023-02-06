/* WriteDesdeTeclado
* Escribir en Fichero 1
Construye un programa que vaya leyendo las frases que el usuario teclea y 
las guarde en un fichero de texto. 
Terminará cuando la frase introducida sea "fin" (esa frase no deberá guardarse en el fichero). 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO; // <-- Necesario para trabajar con ficheros

namespace P31a_Garcia_Sergio // Note: actual namespace depends on the project name.
{
    internal class WritedesdeTeclado
    {
        static void Main(string[] args)
        {
            // Declaramos un stream de escritura
            StreamWriter sw;
            //construyéndolo con uno de sus constructores
            sw = new StreamWriter(@"../../../file1.txt", false, Encoding.Unicode);
            
            Console.WriteLine("Comience a escribir en el texto, para finalizar escriba fin");
            // uso una variable auxiliar
            String frase = "";
            frase = Console.ReadLine();
            while (frase != "fin")
            {
                // escribo la frase en "mi fichero" 
                sw.WriteLine(frase);

                // Leo del teclado la siguiente frase
                frase = Console.ReadLine();
                
            }
            sw.Close();
            Console.WriteLine("\n\nPulsa una tecla para salir");
            Console.ReadKey();
        }
    }
}