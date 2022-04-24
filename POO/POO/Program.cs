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
            //OTRA MANERA DE INSTANCIAR
            var curso1 = new Curso() { Nombre="C#",Jornada=TiposJornada.Tarde};
            var curso2 = new Curso() { Nombre="c++",Jornada=TiposJornada.Manana};
            var curso3 = new Curso() { Nombre="PHP",Jornada=TiposJornada.Noche};

            Console.WriteLine(escuela.ToString());
            Console.WriteLine("===========CURSOS==============");
            Console.WriteLine(curso1.ToString());
            Console.WriteLine(curso2.ToString());
            Console.WriteLine(curso3.ToString());


        }
    }
}
