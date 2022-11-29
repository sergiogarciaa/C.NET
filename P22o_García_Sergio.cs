using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22o_García_Sergio
{
    internal class P22o_García_Sergio
    {
        static void Main(string[] args)
        {
            //Declaracion de Arrays (Primera Parte)
            String[] vApellidos = new string[]
            {
                "Sánchez Elegante","Arenas Mata","García Solís",
                "Rodríguez Vázquez", "Hurtado Miranda", "Pinto Mirinda",
                "Barrios Garrobo", "Márquez Salazar", "Medina Gómez", "Alonso Pérez",
                "López Mora", "González Chaparro", "Ferrer Jiménez", "Morales Moncayo",
                "Fernández Perea", "Blanco Roldán", "Navarro Romero", "Aguilar Rubio",
                "Baena Fernández", "Barco Ramírez", "Delgado Rodríguez", "Duque Martínez"
            };
            String[] vNombres = new string[]
            {
                "Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier",
                "José Manuel", "Tomás", "Carlos", "Jose Carlos", "Juan Luis", "Daniel",
                "Angel", "Jacobo", "Alejandro", "Francisco", "Alfredo", "Francisco",
                "Antonio", "Constantino", "Roberto", "Rafael", "Antonio"
            };
            //Segunda Parte
            //Nombres
            int numPersonas = vNombres.Length;
            //
            String[,] tab2dGente = new string[numPersonas, 2];

            Pausa("cargar el array tab2dGente con el contenido de nombres y apellidos ");


            // Con esto cargamos el array tab2dGente con el contenido de nombres y apellidos
            for (int i = 0; i<numPersonas; i++)
            {
                tab2dGente[i, 0] = vNombres[i];
                tab2dGente[i,1] = vApellidos[i];
            }

            Pausa("presentar nombre y apellidos en orden");
            // Presentar nombre y apellidos en orden
            for (int i=0; i<tab2dGente.GetLength(0); i++)
            {
                                          // Se presenta el indice con 2 ceros
                Console.WriteLine("{0}) {1} {2}", (i+1).ToString("00"), tab2dGente[i,0], tab2dGente[i,1]);
            }

            String[] vApellNomb = new string[numPersonas];

            // Guardar apellido y nombre en el vector vApellNomb
            Pausa("guardar apellido y nombre en el vector vApellNomb");
            for (int i = 0; i < numPersonas; i++)
            {
               vApellNomb[i] = tab2dGente[i, 1] + ", " + tab2dGente[i, 0];
                // Lo mismo cons string.format
            }

            Console.WriteLine(" ");

            Pausa("mostrar vApellNomb");
            // Muestra vApellNomb
            for (int i = 0; i<numPersonas; i++)
            {
                Console.WriteLine("{0}) {1}", (i + 1).ToString("00"), vApellNomb[i]);
            }

            Pausa("Persona con más caracteres");

            string PersonaMasCaracteres = vApellNomb[0];
            for(int i = 1; i<numPersonas; i++) {
                if (vApellNomb[i].Length > PersonaMasCaracteres.Length)
                {
                    PersonaMasCaracteres = vApellNomb[i];
                }
            }
            Console.WriteLine(PersonaMasCaracteres);

            Pausa("salir");

        }
        static void Pausa(string txt)
        {
            Console.WriteLine("\nPulsa una tecla para {0}\n", txt);
            Console.ReadKey(true);
        }
    }
}
