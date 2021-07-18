using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace EjemploSinSPR
{
    //Se toma las caracteristicas de "Sueldo" para mostrar
    class Program : Sueldo
    {
        static void Main(string[] args)
        {
            //Metodo usado para mostrar por pantalla
            Program profesor = new Program();
            Console.WriteLine(profesor);
            profesor.Mostrar();

        }

        


    }
}

    
