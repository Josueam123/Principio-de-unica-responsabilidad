using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploSinSPR
{
    class Sueldo
    {
        private string nombre;
        private string materia;
        private string edad;
        private double sueldo;

        public Sueldo()
        {

            Console.Write("Nombre>");
            string nombre2 = Console.ReadLine();

            Console.Write("Materia>");
            string materia2 = Console.ReadLine();

            Console.Write("Edad>");
            string edad2 = Console.ReadLine();

            Console.Write("Sueldo>");
            double sueldo2 = Convert.ToDouble(Console.ReadLine());

            nombre = nombre2;
            materia = materia2;
            edad = edad2;
            sueldo = sueldo2;
        }


        public double BonoNavidad()
        {
            return sueldo + 50;
        }

        public void Mostrar()
        {

            double SueldoNavidad = BonoNavidad();
            Console.WriteLine("El sueldo final de " + nombre + " con el bono por navidad es: " + SueldoNavidad);

        }
    }
}
