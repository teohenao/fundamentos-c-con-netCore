using System;
using School.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("escuela teo",2019,TiposEscuela.Prescolar,
            pais:"coooloommmbia",ciudad:"Calarcaaa"
            
            );
        
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
