/*EscribirDatosEnTxtConSeparadores 
Construye dos tablas tApell y tNomb con los datos que tienes más abajo, que son los de la práctica P25b. A continuación realizamos el siguiente proceso:
1)	Construimos una tabla de byte tIds con el id de cada alumno, que serán números al azar de dos cifras sin que exista ninguno repetido.
2)	Construimos una tabla de floats tNotas con las mismas filas que la anterior pero de dos dimensiones (tres columnas), para guardar las notas de los alumnos, es decir, en la fila n se guardarán las tres notas del alumno de posición n. Esta tabla se cargará con notas obtenidas al azar, entre 0.0 y 9.9, (con un decimal).
3)	Guardamos los datos en un fichero formando registros con la siguiente estructura:		 id;Apellidos;Nombre;n0;n1;n2
El fichero se llamará fNotasCS.TXT. Los campos irán separados por el carácter ‘;’ y los registros por salto de línea.

Apellidos: "Sánchez Elegante", "Arenas Mata", "García Solís", "Rodríguez Vázquez", "Hurtado Miranda", "Pinto Mirinda", "Barrios Garrobo", "Márquez Salazar", "Medina Gómez", "Alonso Pérez", "López Mora", "González Chaparro", "Ferrer Jiménez", "Morales Moncayo", "Fernández Perea", "Blanco Roldán", "Navarro Romero", "Aguilar Rubio", "Baena Fernández", "Barco Ramírez", "Delgado Rodríguez", "Duque Martínez"
Nombres: "Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier", "José Manuel", "María", "Carlos", "Jose Carlos", "Juan Luis", "Daniel", "Carmen", "Jacobo", "Alejandro", "Francisco", "Alicia", "Francis
*/

using System;

namespace P33a_EscribirDatosEnTxtConSeparadores // Note: actual namespace depends on the project name.
{
    internal class P33a_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            string[] tApell = { "Sánchez Elegante", "Arenas Mata", "García Solís", "Rodríguez Vázquez", "Hurtado Miranda", "Pinto Mirinda", "Barrios Garrobo", "Márquez Salazar", "Medina Gómez", "Alonso Pérez", "López Mora", "González Chaparro", "Ferrer Jiménez", "Morales Moncayo", "Fernández Perea", "Blanco Roldán", "Navarro Romero", "Aguilar Rubio", "Baena Fernández", "Barco Ramírez", "Delegado Rodríguez", "Duque Martínez" };
            string[] tNomb = { "Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier", "José Manuel", "María", "Carlos", "Jose Carlos", "Juan Luis", "Daniel", "Carmen", "Jacobo", "Alejandro", "Francisco", "Alicia", "Francisco", "Ángela", "Constantino", "Mariló", "Rafaela", "Antonio" };

            int tamanyo = tApell.Length;
            byte[] tIds2cifras = cargaIds(tamanyo);
            float[,] tNotas = Carga3Notas(tamanyo);
            
            StreamWriter sw = File.CreateText(@".\Datos\fNotasCS.TXT");
            for (int i = 0; i < tamanyo; i++)
            {
                sw.WriteLine("{0};{1};{2};{3};{4};{5}", tIds2cifras[i], tApell[i], tNomb[i], tNotas[i, 0], tNotas[i, 1], tNotas[i, 2]);
                // igual para verlo en pantalla
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0};{1};{2};{3};{4};{5}", tIds2cifras[i], tApell[i], tNomb[i], tNotas[i, 0], tNotas[i, 1], tNotas[i, 2]);

            }
            sw.Close();

            Console.Write("\n\n\t  Pulse una tecla para salir.");
            Console.ReadKey();
        }

        private static float[,] Carga3Notas(int tamanyo)
        {
            float[,] tNotas = new float[tamanyo, 3];
            Random azar = new Random();

            for (int i = 0; i < tamanyo; i++)
            {
                tNotas[i, 0] = azar.Next(100) / 10F;
                tNotas[i, 1] = azar.Next(100) / 10F;
                tNotas[i, 2] = azar.Next(100) / 10F;
            }
            return tNotas;
        }

        static byte[] cargaIds(int tamanyo)
        {
            byte[] tabIds2Cifras = new byte[tamanyo];
            Random azar = new Random();
            
            List<byte> lista = new List<byte>();
            for (byte b = 10; b < 100; b++) // cargamos la lista con los valores posibles
                lista.Add(b);
            int pos;
            
            for (int i = 0; i < tamanyo; i++)
            {
                pos = azar.Next(lista.Count); // Obtengo una posición al azar de la lista
                tabIds2Cifras[i] = lista[pos];     // Guardo el valor de esa posición en la tabla
                lista.RemoveAt(pos);          // elimino ese elemento de la lista para que no se pueda repetir
            }

            return tabIds2Cifras;
        }
    }
}