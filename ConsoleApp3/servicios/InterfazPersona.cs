using ConsoleApp3.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.servicios
{
    internal interface InterfazPersona
    {
        void nuevaPersona(List<Persona> listaPersona);
        void mostrarPersona(List<Persona> listaPersona);
    }
}
