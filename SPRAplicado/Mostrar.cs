using System;
using System.Collections.Generic;
using System.Text;

namespace SPRAplicado
{
    class Mostrar : Sueldo
    {
        public static void mostrar(Datos sueldo_proceso)
        {
            double SueldoNavidad = BonoNavidad(sueldo_proceso);
            Console.WriteLine("El sueldo final de " + nombre + " con el bono por navidad es: " + SueldoNavidad);
        }
    }
}
