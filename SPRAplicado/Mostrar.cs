using System;
using System.Collections.Generic;
using System.Text;

namespace SPRAplicado
{
    //Metodo del mensaje que se mostrará por pantalla
    //Mostrar toma los atributos de sueldo para "Bono navidad"
    class Mostrar : Sueldo
    {
        public static void mostrar(Datos sueldo_proceso)
        {
            double SueldoNavidad = BonoNavidad(sueldo_proceso);
            Console.WriteLine("El sueldo final de " + Datos.nombre + " con el bono por navidad es: " + SueldoNavidad);
        }
    }
}
