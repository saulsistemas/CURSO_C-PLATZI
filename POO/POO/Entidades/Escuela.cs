
using System;

namespace POO.Entidades
{
    class Escuela
    {
        //private string _nombre;
        //public string Nombre { get { return _nombre; } set { _nombre = value.ToUpper(); } }
        //ENCAPSULAMIENTO
        public string Nombre { get; set; }
        public int AnioCreacion { get; set; }
        public string Pais { get;set; }
        public string Ciudad { get; set; }
        //PROP
        //CONSTRUCTOR
        //public Escuela(string nombre,int anioCreacion)
        //{
        //    Nombre = nombre;
        //    AnioCreacion = ValidarNumero(anioCreacion);
        //}
        public Escuela(string nombre, int anioCreacion)=> (Nombre,AnioCreacion)=(nombre,ValidarNumero(anioCreacion));
        private int ValidarNumero(int anioCreacion)
        {
            if (anioCreacion< 2022)
            {
                return anioCreacion;
            }
            return 0;
        }
    }
}
