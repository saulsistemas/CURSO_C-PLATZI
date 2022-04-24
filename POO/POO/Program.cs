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

            //ARREGLOS
            //int[] are = new int[2];
            //AREGLO DE OBJETOS
            var arregloCursos = new Curso[3];
            //PRIMERA FORMA
            arregloCursos[0]= new Curso() { Nombre = "c++",Jornada = TiposJornada.Manana}; 
            arregloCursos[1]= new Curso() { Nombre = "c++",Jornada = TiposJornada.Tarde};
            //SEGUNDA FORMA
            arregloCursos[2] = new Curso();
            arregloCursos[2].Nombre = "Saul";
            arregloCursos[2].Jornada = TiposJornada.Noche;

            Console.WriteLine(escuela.ToString());
            Console.WriteLine("===========CURSOS==============");
            //imprimirCursosWhile(arregloCursos);
            //imprimirCursosDoWhile(arregloCursos);
            //imprimirCursosFor(arregloCursos);
            imprimirCursosForEach(arregloCursos);
        }

        private static void imprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            //MIENTRAS SIGA SIENDO VERDADERO
            while (contador<=arregloCursos.Length)
            {
                Console.WriteLine(arregloCursos[contador].Nombre +" "+arregloCursos[contador].Jornada);
                contador++;
            }
        }
        private static void imprimirCursosDoWhile(Curso[] arreglo)
        {
            int contador = 0;
            do
            {
                Console.WriteLine(arreglo[contador].Nombre + " " + arreglo[contador].Jornada);
                contador++;
            } while (contador <= arreglo.Length);
            //MIENTRAS SIGA SIENDO VERDADERO
        }
        private static void imprimirCursosFor(Curso[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i].Nombre + " " + arreglo[i].Jornada);
            }
            
        }
        private static void imprimirCursosForEach(Curso[] arreglos)
        {
            foreach (var curso in arreglos)
            {
                Console.WriteLine(curso.Nombre + " " + curso.Jornada);
            }

        }
    }
}
