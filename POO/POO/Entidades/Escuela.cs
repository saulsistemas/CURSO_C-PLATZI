
using System;

namespace POO.Entidades
{
    class Escuela
    {
        
        public string Nombre { get; set; }
        public int AnioCreacion { get; set; }
        public string Pais { get;set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
      
        public Escuela(string nombre, int anioCreacion)=> (Nombre,AnioCreacion)=(nombre,ValidarNumero(anioCreacion));
        //CONSTRUCTOR CON MAS PARAMETROS
        public Escuela(string nombre, int anioCreacio,
                        TiposEscuela tipo,
                        string pais="",string ciudad="")
        {
            (Nombre, AnioCreacion) = (nombre, anioCreacio);//TUPLAS
            TipoEscuela = tipo;
            Pais = pais;
            Ciudad= ciudad;
        }
        private int ValidarNumero(int anioCreacion)
        {
            if (anioCreacion< 2022)
            {
                return anioCreacion;
            }
            return 0;
        }
        //sobre escritura de metodo String
        public override string ToString()
        {
            return $"Nombre:\"{Nombre}\",Tipo:{TipoEscuela} \nPais:{Pais} Ciudad:{Ciudad}";
        }
    }
}
