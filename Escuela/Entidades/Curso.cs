using System;

namespace School.Entidades
{
    public class Curso
    {
        public string UniqueId{get;private set;}
        public string Nombre { get; set; }
        public TiposJornada TipoJornada {get;set;}
        public Curso()=> UniqueId = Guid.NewGuid().ToString();
    }
}