using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace SPRAplicado
{
    //Metodo para mostrar el mensaje por pantalla de la clase "Mostrar"
    class Program 
    {
        static void Main(string[] args)
        {
            Datos profesor = new Datos();
            Console.WriteLine(profesor);
            Console.WriteLine(Sueldo.BonoNavidad(profesor));
            Mostrar.mostrar(profesor);

        }
    }

}

