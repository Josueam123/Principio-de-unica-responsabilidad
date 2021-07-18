using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploSinSPR
{
    class Sueldo
    {
        //Se ingresa 4 variables para posteriormente ser solicitadas por teclado
        private string nombre;
        private string materia;
        private string edad;
        private double sueldo;

        public Sueldo()
        {
            //Uso de metodos para solicitar los datos de tipo string y double en el caso de sueldo
            Console.Write("Nombre>");
            string nombre2 = Console.ReadLine();

            Console.Write("Materia>");
            string materia2 = Console.ReadLine();

            Console.Write("Edad>");
            string edad2 = Console.ReadLine();

            Console.Write("Sueldo>");
            double sueldo2 = Convert.ToDouble(Console.ReadLine());

            //Las variables principales toman los valores que se solicitaron
            nombre = nombre2;
            materia = materia2;
            edad = edad2;
            sueldo = sueldo2;
        }

        //Metodo para sumar el bono extra al sueldo
        public double BonoNavidad()
        {
            return sueldo + 50;
        }
        //Metodo para mostrar por pantalla un mensaje y sueldo a recibir
        public void Mostrar()
        {

            double SueldoNavidad = BonoNavidad();
            Console.WriteLine("El sueldo final de " + nombre + " con el bono por navidad es: " + SueldoNavidad);

        }
    }
}
