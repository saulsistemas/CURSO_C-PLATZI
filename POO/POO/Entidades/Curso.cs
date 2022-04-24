
using System;

namespace POO.Entidades
{
    class Curso
    {
        private string UniqueId { get; set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public Curso() => UniqueId = Guid.NewGuid().ToString();


        public override string ToString()
        {
            return $"El id es :{UniqueId}, nombre: {Nombre} ,  Jornadad {Jornada}";
        }

    }
}
