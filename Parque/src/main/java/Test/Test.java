

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */


package Test;

import Parque.Parque;
import Parque.Guardaparque;
import Parque.Atraccion;
//EJECUTAR ESTE SCRIPT
public class Test {
    public static void main(String[] args) {
        
        String nombreAlumno = "David Santiago Escamilla Castro";
        String codigoAlumno = "7502410012";
        System.out.println("Código: " + codigoAlumno + " | Nombre: " + nombreAlumno);
        System.out.println("******************************");

        
        Parque parqueConParametros = new Parque(" Parque Nacional ", " Bogota ", 500.5);
        Guardaparque guardaparqueConParametros = new Guardaparque(" Diego ", 10, " Intrusos ");
        Atraccion atraccionConParametros = new Atraccion(" Piscina ", " Diversion ", 150.0);

        
        Parque parquePorDefecto = new Parque();
        parquePorDefecto.setNombre(" Parque Jurasico");
        parquePorDefecto.setUbicacion(" Caracas");
        parquePorDefecto.setSuperficie(120.0);

        Guardaparque guardaparquePorDefecto = new Guardaparque();
        guardaparquePorDefecto.setNombre(" Carlos");
        guardaparquePorDefecto.setAntiguedad(5);
        guardaparquePorDefecto.setEspecialidad(" Observador");

        Atraccion atraccionPorDefecto = new Atraccion();
        atraccionPorDefecto.setNombre(" Carrusel");
        atraccionPorDefecto.setTipo(" Infantil");
        atraccionPorDefecto.setPrecio(50.0);

        //Salida de Consola
        System.out.println(parqueConParametros);
        System.out.println(guardaparqueConParametros);
        System.out.println(atraccionConParametros);

        System.out.println(parquePorDefecto);
        System.out.println(guardaparquePorDefecto);
        System.out.println(atraccionPorDefecto);
    }
}