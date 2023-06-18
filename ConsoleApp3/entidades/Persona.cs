using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.entidades
{
    internal class Persona
    {
        private String nombre;
        private String apellidos;
        private int anio;
        private int mes;
        private int dia;

        public Persona(string nombre, string apellidos, int anio, int mes, int dia)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.anio = anio;
            this.mes = mes;
            this.dia = dia;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public override string ToString()
        {
            return "Nombre: " + nombre + " | Apellidos: " + apellidos + " | Año: " + anio + " | Mes: " + mes + " | Día: " + dia;
        }


    }
}
