using POO.Entidades;
using System;

namespace POO
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIAMOS
            var escuela = new Escuela("Saul",2021,TiposEscuela.PreEscolar,ciudad:"Chiclayo");
           
            Console.WriteLine(escuela.ToString());

        }
    }
}
