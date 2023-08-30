using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set;}
        public int Edad { get; set;}
        public string RetornarNombresCompleto() {
            return Nombres + " " + Apellidos;
        }
        public bool EsMayorEdad() {
            return Edad >18; 
        }
    }
}
