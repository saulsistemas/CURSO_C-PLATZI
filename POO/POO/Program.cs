using POO.Entidades;
using System;

namespace POO
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIAMOS
            var escuela = new Escuela("Saul",2021);
            escuela.Pais = "Peru";
            escuela.Ciudad = "Lima";

            Console.WriteLine(escuela.Nombre + " "+ escuela.AnioCreacion);

        }
    }
}
