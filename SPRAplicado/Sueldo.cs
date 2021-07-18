using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace SPRAplicado
{
    class Sueldo : Datos
    {
        public static double BonoNavidad(Datos sueldo_proceso)
        {
            return sueldo_proceso.sueldo_base + 150;
        }

        
    }
}
