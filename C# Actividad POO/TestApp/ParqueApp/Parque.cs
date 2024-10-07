using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParqueApp {
    public class Parque {
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public double Superficie { get; set; }
        public List<Atraccion> Atracciones { get; set; }
        public List<Guardaparque> Guardaparques { get; set; }

        public Parque(string nombre, string ubicacion, double superficie) {
            Nombre = nombre;
            Ubicacion = ubicacion;
            Superficie = superficie;
            Atracciones = new List<Atraccion>();
            Guardaparques = new List<Guardaparque>();
        }

        public Parque()
        {
            Nombre = "Parque desconocido";
            Ubicacion = "Ubicacion desconocida";
            Superficie = 0;
            Atracciones = new List<Atraccion>(); 
            Guardaparques = new List<Guardaparque>(); 
        }

        public override string ToString() {
            return $"Parque(Nombre = {Nombre}, Ubicacion = {Ubicacion}, Superficie = {Superficie})";
        }
    }
}
