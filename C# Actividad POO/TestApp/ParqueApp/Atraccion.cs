using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParqueApp {
    public class Atraccion {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }

        public Atraccion(string nombre, string tipo, double precio) {
            Nombre = nombre;
            Tipo = tipo;
            Precio = precio;
        }

        public Atraccion()
        {
            Nombre = "Atracción Desconocida";
            Tipo = "Tipo Desconocido";
            Precio = 0.0;
        }


        public override string ToString() {
            return $"Atraccion(Nombre = { Nombre}, Tipo = { Tipo}, Precio = { Precio})";
        }
    }
}
