using System;
using School.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("escuela teo",2019);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Armenia";
            Console.WriteLine(escuela.Nombre);
        }
    }
}
