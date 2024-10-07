using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParqueApp {
    public class Guardaparque {
        public string Nombre { get; set; }
        public int Antiguedad { get; set; }
        public string Especialidad { get; set; }
        public List<Atraccion> Atracciones { get; set; }

        public Guardaparque(string nombre, int antiguedad, string especialidad) 
        {
            Nombre = nombre;
            Antiguedad = antiguedad;
            Especialidad = especialidad;
            Atracciones = new List<Atraccion>();
        }

        public Guardaparque()
        {
            Nombre = "No hay Guardaparque";
            Antiguedad = 0;
            Especialidad = "";
            Atracciones = new List<Atraccion>();
        }

        public override string ToString() 
        {
            return $"Guardaparque(Nombre = {Nombre}, Antiguedad = {Antiguedad}, Especialidad = {Especialidad})";
        }
    }
}
