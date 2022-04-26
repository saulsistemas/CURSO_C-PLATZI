using POO.Entidades;
using System;
using static System.Console;
namespace POO
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIAMOS
            var escuela = new Escuela("Saul",2021,TiposEscuela.PreEscolar,ciudad:"Chiclayo");

            //ARREGLOS
            //int[] are = new int[2];
            //AREGLO DE OBJETOS OPTIMIZADO
            //Curso[] arregloCursos = 
            //{
            //    new Curso() { Nombre = "c++",Jornada = TiposJornada.Manana},
            //    new Curso() { Nombre = "c++",Jornada = TiposJornada.Tarde},
            //    new Curso() { Nombre = "PHP",Jornada = TiposJornada.Noche}
            //};
            escuela.Curso = new Curso[]
            {
                new Curso() { Nombre = "c++",Jornada = TiposJornada.Manana},
                new Curso() { Nombre = "c++",Jornada = TiposJornada.Tarde},
                new Curso() { Nombre = "PHP",Jornada = TiposJornada.Noche}
            };
            imprimirCursosEscuela(escuela);
        }

        private static void imprimirCursosEscuela(Escuela escuela)
        {
            if(escuela.Curso == null)
            {
                return;
            }
            WriteLine("===========CURSOS==============");
            foreach (var curso in escuela.Curso)
            {
                WriteLine(curso.Nombre + " " + curso.Jornada);
            }
        }

        
    }
}
