using System;

namespace POO
{
    //PLANTILLA
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int anioFundacion;
        public string ceo ="Saul Santamaria";

        //METODO QUE NO RETORNA NADA
        //void timbrar() => Console.Beep(10000, 3000);

        public void timbrar()
        {
            Console.Beep(10000, 1000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIAMOS
            var miEscuela = new Escuela();
            miEscuela.nombre = "Los siervos de jesus";
            string direccion = miEscuela.direccion = "Av Lima 1140";
            miEscuela.anioFundacion = 2020;
            Console.WriteLine("Mi escuela va timbrar");
            miEscuela.timbrar();
            Console.WriteLine($"El nombre es {miEscuela.nombre}, la direccion es {direccion}");

        }
    }
}
