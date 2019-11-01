
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void Inicializar()
        {
            Escuela = new Escuela("escuela teo", 2019, TiposEscuela.Prescolar,
                                   pais: "coooloommmbia", ciudad: "Calarcaaa"
                                 );

            Escuela.Cursos = new List<Curso>(){
            new Curso(){Nombre = "101",TipoJornada = TiposJornada.Mañana},
            new Curso(){Nombre = "201",TipoJornada = TiposJornada.Tarde},
            new Curso(){Nombre = "301",TipoJornada = TiposJornada.Noche},
            new Curso(){Nombre = "401",TipoJornada = TiposJornada.Mañana},
            new Curso(){Nombre = "501",TipoJornada = TiposJornada.Mañana}
            };
        }

    }
}