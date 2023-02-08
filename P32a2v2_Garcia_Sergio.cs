using System.Drawing;
using System.Text;
using System.Xml.Schema;

namespace P32a2_LeerficheroGestionandoParrafos;
/*
LeerFicheroTXT Versión 2: 
•	Instalar una carpeta Datos dentro del directorio de trabajo por defecto y colocar en dicha carpeta los archivos a leer. 
Construir el método: CapturaRuta: 
Recibe: Nada
Hace: Pide al usuario el nombre de un fichero 
•	Si existe en la carpeta Datos, devuelve la ruta completa. 
   Importante: comprobará la existencia del fichero, mediante ruta relativa.
•	Si no, da mensaje de error y vuelve a pedir el nombre del fichero.

Realizar el siguiente programa:
•	Instalar una carpeta Datos dentro del directorio de trabajo y colocar en dicha carpeta los archivos a leer.
•	La apertura del fichero se realizará mediante ruta relativa.
•	Hacer que vaya leyendo las líneas del fichero que se indique y las muestre en pantalla. 
•	Después de mostrar el fichero, presentará cuántos párrafos tiene 
   y repetirá el párrafo más largo indicando el número de caracteres que tiene.
*/
public class P32a2v2_Garcia_Sergio
{
   const string CARPETAORIGEN = @"./Datos/";
    
   public static void Main(string[] args)
    {
       string parrafo, parrafoMayor = String.Empty, ruta = CapturaRuta();
       StreamReader sr;
       int numParrafos = 0;
       
       sr = new StreamReader(ruta, Encoding.Default);
       while (!sr.EndOfStream)
       {
          parrafo = sr.ReadLine();
          Console.Write(parrafo);
          numParrafos++;
          if (parrafo.Length > parrafoMayor.Length)
          {
             parrafoMayor = parrafo;
          }
       }

       Console.ForegroundColor = ConsoleColor.DarkGreen;
       Console.Write("\n\n Tiene {0} parrafos, el párrafo más largo tiene {1} carácteres, es el siguiente: \n",
          numParrafos, parrafoMayor.Length);
       Console.Write(parrafoMayor);
       Console.ForegroundColor = ConsoleColor.DarkCyan;
       Console.Write("\n\n Pulsa una tecla para salir");
       Console.ForegroundColor = ConsoleColor.White;
       Console.ReadKey();
       sr.Close();
    }

    static string CapturaRuta()
    {
       string ruta;
       string[] files = Directory.GetFiles(@"./Datos/"); // Obtener archivos
       do
       {
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          foreach (string f in files)
          {
             Console.WriteLine(f); // Mostramos los archivos en la consola
          }

          Console.ForegroundColor = ConsoleColor.White;
          Console.Write("¿Qué archivo desea leer?: \n");
          ruta = CARPETAORIGEN + Console.ReadLine() + ".txt"; // Elegimos el archivo
          if (!File.Exists(ruta))
          {
             Console.ForegroundColor = ConsoleColor.Red;
             Console.Write("ERROR: El nombre de archivo introducido no corresponde a ningún archivo.\n");
             Console.ForegroundColor = ConsoleColor.White;
          }
       } while (!File.Exists(ruta));

       return ruta;
    }
}