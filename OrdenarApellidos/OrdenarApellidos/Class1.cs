using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarApellidos
{
    internal class Class1
    {
        // 1.- Objeto Persona 
        public string nombre { get; set; }
        public string apellido { get; set; }


        // ---------------------------------------------------------------------------------
        public Class1()
        {

                Console.WriteLine("Para salir: [salir]");
                Console.WriteLine("Introduce nombre: ");
                nombre = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Introduce apellido: ");
                apellido = Convert.ToString(Console.ReadLine());
        }
        // ---------------------------------------------------------------------------------
        public void verDatos()
        {
            Console.WriteLine(" Nombre : " + this.nombre + " | Apellido : " + this.apellido);
        }

       
        public void EliminarAlumno(List<Class1> listaAlumnos)
        {
            Class1 aBorrar = new Class1();
            String name;

            Console.WriteLine("Introduzca el nombre de la persona que quiere borrar");
            name = Console.ReadLine();
            if(name == aBorrar.nombre)
            listaAlumnos.Remove(aBorrar);
            
        }
    }
}
