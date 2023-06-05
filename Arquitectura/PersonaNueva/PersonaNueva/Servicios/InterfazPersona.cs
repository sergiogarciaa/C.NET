using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PersonaNueva.Entidades;

namespace PersonaNueva.Servicios
{
    internal interface InterfazPersona
    {
        void nuevaPersona(List<Persona> listaPersona);
        void mostrarPersona(List<Persona> listaPersona);
    }
}
