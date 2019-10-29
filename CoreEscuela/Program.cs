using System;

namespace CoreEscuela
{
    class CoreEscuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo = "teo";

        public void Timbrar()
        {
            //Todo
            Console.WriteLine("timbrando");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new CoreEscuela();
            miEscuela.nombre = "teoSchool";
            miEscuela.direccion = "calarca";
            miEscuela.añoFundacion = 2019;
            Console.WriteLine("timbrar");
            miEscuela.Timbrar();
            Console.WriteLine("Hello World!");
        }
    }
}
