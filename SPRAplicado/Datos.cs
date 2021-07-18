using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace SPRAplicado
{
    
    class Datos 
    {
        public static string nombre;
        private string materia;
        private string edad;
        public double sueldo_base;

        public Datos()
        {

            Console.Write("Nombre>");
            string nombre_ingreso = Console.ReadLine();

            Console.Write("Materia>");
            string materia_ingreso = Console.ReadLine();

            Console.Write("Edad>");
            string edad_ingreso = Console.ReadLine();

            Console.Write("Sueldo>");
            double sueldo_ingreso = Convert.ToDouble(Console.ReadLine());

            nombre = nombre_ingreso;
            materia = materia_ingreso;
            edad = edad_ingreso;
            sueldo_base = sueldo_ingreso;
        }
    }
}