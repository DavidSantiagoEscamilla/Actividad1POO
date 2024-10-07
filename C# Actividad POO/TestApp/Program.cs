using System;
using ParqueApp;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string nombreAlumno = "David Santiago Escamilla Castro";
            string codigoAlumno = "7502410012";
            Console.WriteLine("Código: " + codigoAlumno + " | Nombre: " + nombreAlumno);
            Console.WriteLine("******************************");

            
            Parque parqueConParametros = new Parque("Parque Nacional", "Montañas", 500.5);
            Guardaparque guardaparqueConParametros = new Guardaparque(" Carlos Ruiz", 10, " Amante a las frutas");
            Atraccion atraccionConParametros = new Atraccion(" Montaña Rusa", " Diversión", 150.0);

            
            Parque parquePorDefecto = new Parque();
            parquePorDefecto.Nombre = " Parque Urbano";
            parquePorDefecto.Ubicacion = " Ciudad";
            parquePorDefecto.Superficie = 120.0;

            Guardaparque guardaparquePorDefecto = new Guardaparque();
            guardaparquePorDefecto.Nombre = " Ana López";
            guardaparquePorDefecto.Antiguedad = 5;
            guardaparquePorDefecto.Especialidad = " Animalista";

            Atraccion atraccionPorDefecto = new Atraccion();
            atraccionPorDefecto.Nombre = " Carrusel";
            atraccionPorDefecto.Tipo = " Infantil";
            atraccionPorDefecto.Precio = 50.0;

            // Mostrar los datos de cada objeto creado utilizando ToString()
            Console.WriteLine(parqueConParametros.ToString());
            Console.WriteLine(guardaparqueConParametros.ToString());
            Console.WriteLine(atraccionConParametros.ToString());

            Console.WriteLine(parquePorDefecto.ToString());
            Console.WriteLine(guardaparquePorDefecto.ToString());
            Console.WriteLine(atraccionPorDefecto.ToString());
        }
    }
}
