//Alumno: García Barrera, Sergio


/*Vector de Floats:
Define los dos métodos siguientes (además de CapturaEntero, claro):
ConstruyeVectorFloats, que recibe un entero, tamanyo y devuelve un vector de
floats, de dicho tamaño, cargado con números decimales aleatorios compuestos por
dos cifras enteras y dos decimales, ejemplos: 54,96; 27,00; etc.
Pista: Al dividir un número entero entre 100, tenemos un número con dos decimales.
MuestraVectorFloats, que recibe un vector de floats, y el número de columnas.
Este método presenta, en el número de columnas recibido, todos los elementos del
vector, precedidos por su índice.
Importante: Mostrará los números con dos decimales, con independencia de su valor.
Para eso se puede usar num.ToString("00.00")
---------------- En el main -----------------
Utilizando los métodos que correspondan...
Se pide el tamaño de un vector [10..100] y a partir de ahí construye un vector de
float, de nombre vFloats de dicho tamaño.
A continuación, pedirá el número de columnas [1..7].
Por último, mostrará los valores del vector según el número de columnas indicado
Nota: Prueba con 7 columnas e intenta que quede centrada*/


using System;


namespace P22g_VectorDeFloats
{
    internal class P22g_Garcia_Sergio
    {
        static void Main(string[] args)
        {
            int tamanyo;
            int col;

            tamanyo = CapturaEntero("Introduce un número entero", 1,100);

            Pausa("construir vector");
            float[] vFloats = ConstruyeVectorFloats(tamanyo);

            Pausa("pedir columnas");
            col = CapturaEntero("Introduce cuántas columnas desea", 1, 7);

            Pausa("mostrar vector");
            MuestraVectorFloats(vFloats, col);

            Pausa("para salir");
        }

        static void MuestraVectorFloats(float[] vFloats, int col)
        {
            // Mostrar vector
            for (int i = 0; i<vFloats.Length; i++)
            {
                if (i % col == 0)
                {
                    Console.WriteLine();
                }
                if(i<10)
                    Console.Write(" ");

                Console.Write(" {0}) {1} ", i, vFloats[i].ToString("00.00"));
            }
        }

        // Construir Vector
        static float[] ConstruyeVectorFloats(int tamanyo)
        {
            float[] vFloats = new float[tamanyo];
            // Se rellena la tabla con valores alaeatorios de 2 cifras
            Random gen = new Random();
            // Guardo valores entre 10.00 y 99.99 incluido
            for(int i = 0; i < vFloats.Length; i++)
            {   
                                        // con la F mayúscula se convierte a Float
                vFloats[i] = (float)gen.Next(1000, 10000) / 100F;
            }

            return vFloats;  
        }

        static void Pausa(string texto)
        {
            Console.WriteLine("\nPulse una tecla para {0}\n", texto);
            Console.ReadKey(true);
            Console.Clear();
        }

        static int CapturaEntero(string texto, int min, int max)
        {
            bool esCorrecto;
            int valor;
            do
            {
                Console.Write("{0} [{1}..{2}]:", texto, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto)
                    Console.WriteLine("\n\n\t** Error: el valor introducido no es un número entero");
                else if (valor < min || valor > max)
                {
                    esCorrecto = false;
                    Console.WriteLine("\n\n\t** Error: el valor introducido no está dentro del rango");
                }
            } while (!esCorrecto);
            return valor;
        }
    }
}
