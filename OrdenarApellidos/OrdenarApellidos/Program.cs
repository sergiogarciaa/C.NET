using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarApellidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista de Alumnos y Ordenar por apellido
            // 1.- Instanciar.
            Class1 class1 = new Class1();
            List<Class1> listaAlumnos = new List<Class1>();

            Boolean seguir = true;

            // 2.- Llamada a métodos
            while (seguir)
            {
                switch (eligeopcion())
                {
                    case 1:
                        // Añadir alumno a la clase
                        listaAlumnos.Add(class1);
                        break;
                    case 2:
                        // Imprimir lista
                        foreach (Class1 element in listaAlumnos)
                        {
                           element.verDatos();
                        }
                        break;
                    case 3:
                        // Borrar
                        int i = 0;
                        Console.WriteLine("Indique el nombre del alumno");
                        String borrarNombre = Console.ReadLine();   
                        for (i = 0; i < listaAlumnos.Count; i++)
                        {
                            if (listaAlumnos[i].nombre.Equals(borrarNombre))
                            {
                                listaAlumnos.RemoveAt(i);
                            }
                            if (listaAlumnos[i].nombre == null)
                            {

                            }
                        }
                                                
                        break;
                    default:
                        seguir = false;
                        break;
                }
            }
        }

        private static int eligeopcion()
        {
            int resultado = 0;
            Console.WriteLine("1 Añadir");
            Console.WriteLine("2 Listar");
            Console.WriteLine("3 Borrar");
            Console.WriteLine("0 Salir");
            resultado = Convert.ToInt32(Console.ReadLine());
            return resultado;
        }
    }
}
