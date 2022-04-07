using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string cedula;

        //public Persona(string nombre, string apellido, int edad, string cedula)
        //{
        //    this.Nombre = nombre;
        //    this.Apellido = apellido;
        //    this.Edad = edad;
        //    this.Cedula = cedula;
        //}

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        Persona[] GrupoPersona =
        {
            new Persona(){Nombre="Cesar",Apellido="Jafet",Edad=18,Cedula="1265664435"},
             new Persona(){Nombre="yader",Apellido="Mendez",Edad=19,Cedula="126566435435"}
        };
    }
}
