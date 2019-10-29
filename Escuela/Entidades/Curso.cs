using System;

namespace School.Entidades
{
    public class Curso
    {
        public string UniqueId{get;private set;}
        public string Nombre { get; set; }
        public TiposJornada TipoJornada {get;set;}

        //generar id automatimente, constructo, pero en este momento se repite 
        public Curso()=> UniqueId = Guid.NewGuid().ToString();
    }
}