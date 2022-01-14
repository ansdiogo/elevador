using System;
using elevador.Controller;

namespace elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartElevador();
        }
        public static void StartElevador()
        {
            Inicializar.Predio();
            //inicializa no Andar=0;
            Inicializar.Elevador();
        }
    }
}
