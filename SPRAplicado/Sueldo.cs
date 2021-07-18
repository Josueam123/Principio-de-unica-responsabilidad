using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace SPRAplicado
{
    //Hacemos que sueldo tambien tome atributos de "Datos" para la suma de los valores
    class Sueldo : Datos
    {
        //Metodo para la suma "150" que es el valor a agregar al sueldo base
        public static double BonoNavidad(Datos sueldo_proceso)
        {
            
            return sueldo_proceso.sueldo_base + 150;
        }

        
    }
}
